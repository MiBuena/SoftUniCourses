using System.Collections.Generic;
using System.Data.Entity.SqlServer.Utilities;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels.Courses;
using LearningSystem.Services.Interfaces;

namespace LearningSystem.Services.Services
{
    public class HomeService : Service, IHomeService
    {
        public IEnumerable<AllCoursesViewModel> GetAllCourses(string userId)
        {

            var student = this.Context.Students.FirstOrDefault(x=>x.UserId == userId);

            IList<Course> courses = this.Context.Courses.ToList();

            var coursesViewModels = Mapper.Map<IList<Course>, IList<AllCoursesViewModel>> (courses);

            for (int i = 0; i < courses.Count; i++)
            {
                if (userId == null)
                {
                    coursesViewModels[i].HasCurrentUserEnrolledForThisCourse = false;
                }
                else
                {
                    if (courses[i].CourseRecords.Any(x => x.StudentId == student.Id))
                    {
                        coursesViewModels[i].HasCurrentUserEnrolledForThisCourse = true;
                    }
                }
            }

            return coursesViewModels;
        }
    }
}
