using System.Data.Entity;
using System.Linq;
using LearningSystem.Models.EntityModels;
using LearningSystem.Services.Interfaces;

namespace LearningSystem.Services.Services
{
    public class CourseService : Service, ICourseService
    {

        public bool IsCourseOpen(int courseId)
        {
            var course = this.Context.Courses.Find(courseId);

            return course.CanStudentsSignInAndOut;
        }


        public void RegisterToCourse(string userId, int courseId)
        {
            var course = this.Context.Courses.Find(courseId);

            var student = this.Context.Students.Include(x => x.User).FirstOrDefault(x => x.User.Id == userId);


            student.CourseRecords.Add(new CourseGrade()
            {
                Course = course
            });



            this.Context.SaveChanges();
        }

        public void SignOutFromCourse(string userId, int courseId)
        {
            var student = this.Context.Students.Include(x => x.User).FirstOrDefault(x => x.User.Id == userId);

            var courseGradeItem = student.CourseRecords.FirstOrDefault(x => x.CourseId == courseId);

            student.CourseRecords.Remove(courseGradeItem);

            this.Context.SaveChanges();
        }

    }
}

