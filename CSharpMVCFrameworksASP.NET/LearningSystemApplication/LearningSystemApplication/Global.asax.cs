using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI.WebControls.WebParts;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Models.ViewModels.Courses;
using Microsoft.AspNet.Identity.EntityFramework;
using SetRolesViewModel = LearningSystem.Models.ViewModels.SetRolesViewModel;

namespace LearningSystemApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterMaps();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterMaps()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Course, AllCoursesViewModel>()
                    .ForMember(course => course.TrainerName,
                        m => m.MapFrom(course => course.Trainer.UserName))

                .ForMember(course => course.StudentsCount,
        m => m.MapFrom(course => course.CourseRecords.Count));

                expression.CreateMap<Article, AllArticlesViewModel>()
                    .ForMember(article => article.AuthorName,
                        m => m.MapFrom(article => article.Author.UserName));

                expression.CreateMap<Student, ProfileViewModel>()
                                .ForMember(student => student.Grades,
        m => m.MapFrom(student => student.CourseRecords));

                expression.CreateMap<Student, EditUserProfileViewModel>()
                                                .ForMember(student => student.Username,
        m => m.MapFrom(student => student.User.UserName))
        
        .ForMember(student => student.Email,
        m => m.MapFrom(student => student.User.Email))
                 .ForMember(student => student.UserId,
        m => m.MapFrom(student => student.User.Id));

                expression.CreateMap<EditStudentProfileBindingModel, Student>();

                expression.CreateMap<EditStudentProfileBindingModel, ApplicationUser>();

                expression.CreateMap<Course, AllTrainersCoursesViewModel>();

                expression.CreateMap<Student, StudentsInCourseViewModel>();

                expression.CreateMap<NewArticleBindingModel, Article>();

                expression.CreateMap<AddNewCourseBindingModel, Course>();

                expression.CreateMap<AddNewCourseBindingModel, AddNewCourseViewModel>();

                expression.CreateMap<Course, EditCourseViewModel>();

                expression.CreateMap<IdentityRole, RoleViewModel>();

                expression.CreateMap<ApplicationUser, PersonRoleViewModel>();

                expression.CreateMap<Student, TrainerViewModel>()

                    .ForMember(student => student.Id,
                        m => m.MapFrom(student => student.User.Id))

                             .ForMember(student => student.Name,
                        m => m.MapFrom(student => student.Name));

                expression.CreateMap<NewArticleBindingModel, NewArticleViewModel>();



            });



        }
    }
}
