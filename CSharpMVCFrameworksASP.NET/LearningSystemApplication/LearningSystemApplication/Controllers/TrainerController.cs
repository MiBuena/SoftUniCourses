using System.Web.Mvc;
using LearningSystem.Models.BindingModels;
using LearningSystem.Services.Interfaces;
using LearningSystemApplication.Attributes;
using Microsoft.AspNet.Identity;

namespace LearningSystemApplication.Controllers
{
    [MyAuthorize(Roles = "Trainer")]
    public class TrainerController : Controller
    {
        private ITrainersService service;

        public TrainerController(ITrainersService trainersService)
        {
            this.service = trainersService;
        }

        // GET: Blog/Trainer
        public ActionResult AllCourses()
        {
            string currentUserId = User.Identity.GetUserId();

            var courses = this.service.GetAllTrainersCoursesViewModels(currentUserId);

            return View(courses);
        }

        public ActionResult AssessStudents(int courseId)
        {
            string currentUserId = User.Identity.GetUserId();

            var isCourseTrainer = this.service.IsTrainerOfTheCourse(currentUserId, courseId);

            if (!isCourseTrainer)
            {
                return this.RedirectToAction("AllCourses");
            }

            var isOver = this.service.IsCourseOver(courseId);


            if (!isOver)
            {
                return this.RedirectToAction("AllCourses");
            }


            var studentsInCourse = this.service.GetAllStudentsInCourse(courseId);

            return View(studentsInCourse);
        }

        [HttpPost]
        public ActionResult AssessStudents(AssessStudentsBindingModel model)
        {
            string currentUserId = User.Identity.GetUserId();

            var isCourseTrainer = this.service.IsTrainerOfTheCourse(currentUserId, model.CourseId);

            if (!isCourseTrainer)
            {
                return View("Unauthorized");
            }

            var isOver = this.service.IsCourseOver(model.CourseId);


            if (!isOver)
            {
                return this.RedirectToAction("AllCourses");
            }


            if (this.ModelState.IsValid)
            {
                this.service.ChangeStudentGrades(model);
                return this.RedirectToAction("AllCourses");
            }

            return this.View(this.service.GetAllStudentsInCourse(model.CourseId));
        }
    }
}