using System.Collections.Generic;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.ViewModels;

namespace LearningSystem.Services.Interfaces
{
    public interface ITrainersService
    {
        bool IsCourseOver(int courseId);
        bool IsTrainerOfTheCourse(string userId, int courseId);
        IEnumerable<AllTrainersCoursesViewModel> GetAllTrainersCoursesViewModels(string trainerId);
        AssessStudentsViewModel GetAllStudentsInCourse(int courseId);
        void ChangeStudentGrades(AssessStudentsBindingModel model);
    }
}