using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Services.Interfaces;

namespace LearningSystem.Services.Services
{
    public class TrainersService : Service, ITrainersService
    {

        public bool IsCourseOver(int courseId)
        {
            var course = this.Context.Courses.Find(courseId);

            bool isOver = course.EndDate >= DateTime.Now;

            return isOver;
        }

        public bool IsTrainerOfTheCourse(string userId, int courseId)
        {
            var course = this.Context.Courses.Find(courseId);

            if (course.Trainer.Id == userId)
            {
                return true;
            }

            return false;
        }

        public IEnumerable<AllTrainersCoursesViewModel> GetAllTrainersCoursesViewModels(string trainerId)
        {
            var trainersCourses = this.Context.Courses.Where(x => x.Trainer.Id == trainerId);

            var coursesViewModels = Mapper.Map<IEnumerable<Course>, IEnumerable<AllTrainersCoursesViewModel>>(trainersCourses);

            return coursesViewModels;
        }

        public AssessStudentsViewModel GetAllStudentsInCourse(int courseId)
        {
            var students = this.Context.Students.Where(x => x.CourseRecords.Any(y => y.CourseId == courseId));

            var gradesViewModel = new List<GradesViewModel>();

            foreach (var student in students)
            {
                var courseGrade = student.CourseRecords.FirstOrDefault(x => x.CourseId == courseId);

                gradesViewModel.Add(new GradesViewModel()
                {
                    Grade = courseGrade.Grade,
                    StudentId = courseGrade.StudentId,
                    Name = student.Name
                });
            }

            AssessStudentsViewModel viewModel = new AssessStudentsViewModel()
            {
                CourseId = courseId,
                Grades = gradesViewModel
            };

            return viewModel;

        }

        public void ChangeStudentGrades(AssessStudentsBindingModel model)
        {
            foreach (var grade in model.Grades)
            {
                var student = this.Context.Students.Find(grade.StudentId);

                var courseRecord = student.CourseRecords.FirstOrDefault(x => x.CourseId == model.CourseId);

                courseRecord.Grade = grade.Grade;
            }

            this.Context.SaveChanges();
        }
    }
}
