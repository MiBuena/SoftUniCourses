using System.Web.Mvc;
using LearningSystem.Services.Interfaces;
using Microsoft.AspNet.Identity;

namespace LearningSystemApplication.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [Authorize]
        public ActionResult SignUp(int courseId)
        {
            bool isCourseOpenForSignUpAndSignOut = this.courseService.IsCourseOpen(courseId);

            if (isCourseOpenForSignUpAndSignOut)
            {
                string currentUserId = User.Identity.GetUserId();

                this.courseService.RegisterToCourse(currentUserId, courseId);
                return this.RedirectToAction("Index", "Home", new {area = ""});

            }

            return this.RedirectToAction("About", "Home", new { area = "" });
        }

        [Authorize]
        public ActionResult SignOut(int courseId)
        {
            bool isCourseOpenForSignUpAndSignOut = this.courseService.IsCourseOpen(courseId);

            if (isCourseOpenForSignUpAndSignOut)
            {
                string currentUserId = User.Identity.GetUserId();
                this.courseService.SignOutFromCourse(currentUserId, courseId);

                return this.RedirectToAction("Index", "Home");

            }

            return this.RedirectToAction("About", "Home");
        }
    }
}