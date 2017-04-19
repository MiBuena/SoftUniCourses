using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningSystem.Services;
using LearningSystem.Services.Interfaces;
using LearningSystem.Services.Services;
using LearningSystemApplication.Attributes;
using Microsoft.AspNet.Identity;

namespace LearningSystemApplication.Controllers
{
    public class HomeController : Controller
    {
        private IHomeService service;

        public HomeController(IHomeService homeService)
        {
            this.service = homeService;
        }


        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();

            var courses = this.service.GetAllCourses(currentUserId);

            return View(courses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            HttpPostedFileBase file = this.Request.Files[0];

            string fileName = Path.GetFileName(file.FileName);

            string path = Path.Combine(Server.MapPath("~/UploadedFiles"), fileName);

            file.SaveAs(path);

            return this.RedirectToAction("Index");
        }
    }
}