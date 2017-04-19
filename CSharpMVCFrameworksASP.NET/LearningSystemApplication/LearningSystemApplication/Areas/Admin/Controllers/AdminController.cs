using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Models.ViewModels.Courses;
using LearningSystem.Services;
using LearningSystem.Services.Interfaces;
using LearningSystem.Services.Services;
using LearningSystemApplication.Attributes;
using Microsoft.AspNet.Identity;
using SetRolesViewModel = LearningSystem.Models.ViewModels.SetRolesViewModel;

namespace LearningSystemApplication.Areas.Admin.Controllers
{
    [MyAuthorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private IAdministratorService service;

        public AdminController(IAdministratorService administratorService)
        {
            this.service = administratorService;
        }

        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCourse()
        {
            var courseViewModel = this.service.GetAddCourseViewModel();

            return View(courseViewModel);
        }

        [HttpPost]
        public ActionResult AddCourse([Bind(Include = "Name,Description,TrainerId,StartDate,EndDate")]AddNewCourseBindingModel bindingModel)
        {
            if (this.ModelState.IsValid)
            {
                this.service.AddCourse(bindingModel);

                return this.RedirectToAction("Index", "Home", new { area = "" });
            }

            var courseViewModel = this.service.GetCourseViewModelAfterInvalid(bindingModel);


            return View(courseViewModel);
        }

        public ActionResult Edit(int courseId)
        {
            var userProfileViewModel = this.service.GetCourseEditViewModel(courseId);

            return View(userProfileViewModel);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,TrainerId,StartDate,EndDate")] EditCourseBindingModel editCourseBindingModel)
        {
            if (this.ModelState.IsValid)
            {
                this.service.EditCourse(editCourseBindingModel);
                return this.RedirectToAction("Index", "Home", new {area = ""});
            }

            return this.View(this.service.GetCourseEditViewModel(editCourseBindingModel.Id));
        }

        public ActionResult SetRoles()
        {
            var setRolesViewModel = this.service.GetSetRolesViewModel();


            return View(setRolesViewModel);
        }

        [HttpPost]
        public ActionResult SetRoles(SetRolesBindingModel setRolesBindingModel)
        {
            if (this.ModelState.IsValid)
            {
                this.service.SetRoles(setRolesBindingModel);
                return this.RedirectToAction("Index", "Home", new { area = "" });
            }

            var viewModels = this.service.GetSetRolesViewModel();

            return View(viewModels);

        }
    }


}
