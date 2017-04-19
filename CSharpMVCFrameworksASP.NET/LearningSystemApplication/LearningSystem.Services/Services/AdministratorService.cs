using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Models.ViewModels.Courses;
using LearningSystem.Services.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SetRolesViewModel = LearningSystem.Models.ViewModels.SetRolesViewModel;

namespace LearningSystem.Services.Services
{
    public class AdministratorService : Service, IAdministratorService
    {

        public AddNewCourseViewModel GetCourseViewModelAfterInvalid(AddNewCourseBindingModel bindingModel)
        {
            var courseViewModel = Mapper.Map<AddNewCourseBindingModel, AddNewCourseViewModel>(bindingModel);

            var trainersViewModels = this.GetTrainersViewModels();

            courseViewModel.TrainerViewModels = trainersViewModels;

            return courseViewModel;
        }

        public AddNewCourseViewModel GetAddCourseViewModel()
        {
            var trainerViewModels = this.GetTrainersViewModels();

            AddNewCourseViewModel model = new AddNewCourseViewModel();

            model.TrainerViewModels = trainerViewModels;

            return model;

        }

        private ICollection<TrainerViewModel> GetTrainersViewModels()
        {
            var students = this.Context.Students.ToList();

            ICollection<TrainerViewModel> trainerViewModels = new List<TrainerViewModel>();

            foreach (var student in students)
            {
                var trainerViewModel = Mapper.Map<Student, TrainerViewModel>(student);

                trainerViewModels.Add(trainerViewModel);
            }
            return trainerViewModels;
        }


        public void AddCourse(AddNewCourseBindingModel bindingModel)
        {
            var course = Mapper.Map<AddNewCourseBindingModel, Course>(bindingModel);

            course.Trainer = this.Context.Users.Find(bindingModel.TrainerId);

            this.Context.Courses.Add(course);

            this.Context.SaveChanges();
        }

        public SetRolesViewModel GetSetRolesViewModel()
        {
            SetRolesViewModel model = new SetRolesViewModel();

            var roles = this.Context.Roles.ToList();

            var rolesViewModels = Mapper.Map<List<IdentityRole>, List<RoleViewModel>>(roles);

            model.AllRoles = rolesViewModels;



            var users = this.Context.Users.ToList();

            model.PersonRoles = new List<PersonRoleViewModel>();


            foreach (var user in users)
            {
                var userViewModel = Mapper.Map<ApplicationUser, PersonRoleViewModel>(user);

                userViewModel.CurrentRoleViewModels = new List<RoleViewModel>();

                foreach (var role in user.Roles)
                {
                    var contextRole = this.Context.Roles.Find(role.RoleId);

                    var roleModel = Mapper.Map<IdentityRole, RoleViewModel>(contextRole);

                    userViewModel.CurrentRoleViewModels.Add(roleModel);
                }

                model.PersonRoles.Add(userViewModel);

            }

            return model;
        }

        public EditCourseViewModel GetCourseEditViewModel(int courseId)
        {
            var course = this.Context.Courses.Find(courseId);

            var courseViewModel = Mapper.Map<Course, EditCourseViewModel>(course);

            var students = this.Context.Students.ToList();

            ICollection<TrainerViewModel> trainerViewModels = new List<TrainerViewModel>();

            foreach (var student in students)
            {
                var trainerViewModel = Mapper.Map<Student, TrainerViewModel>(student);

                trainerViewModels.Add(trainerViewModel);
            }


            courseViewModel.AllTrainersViewModels = trainerViewModels;

            return courseViewModel;
        }

        public void EditCourse(EditCourseBindingModel editCourseBindingModel)
        {
            var course = this.Context.Courses.Find(editCourseBindingModel.Id);

            course.Trainer = this.Context.Users.Find(editCourseBindingModel.TrainerId);

            this.Context.Entry(course).CurrentValues.SetValues(editCourseBindingModel);

            this.Context.SaveChanges();

        }

        public void SetRoles(SetRolesBindingModel setRolesBindingModel)
        {
            
            foreach (var combination in setRolesBindingModel.PersonRoles)
            {
                if (combination.NewRoleName != null)
                {
                    this.UserManager.AddToRole(combination.Id, combination.NewRoleName);
                }
            }

            this.Context.SaveChanges();
        }
    }
}

