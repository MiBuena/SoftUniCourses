using System.Collections.Generic;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Models.ViewModels.Courses;

namespace LearningSystem.Services.Interfaces
{
    public interface IAdministratorService
    {
        void AddCourse(AddNewCourseBindingModel bindingModel);
        SetRolesViewModel GetSetRolesViewModel();
        EditCourseViewModel GetCourseEditViewModel(int courseId);
        AddNewCourseViewModel GetAddCourseViewModel();
        void EditCourse(EditCourseBindingModel editCourseBindingModel);
        void SetRoles(SetRolesBindingModel setRolesBindingModel);
        AddNewCourseViewModel GetCourseViewModelAfterInvalid(AddNewCourseBindingModel bindingModel);
    }
}