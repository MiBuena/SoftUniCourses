using LearningSystem.Models.BindingModels;
using LearningSystem.Models.ViewModels;

namespace LearningSystem.Services.Interfaces
{
    public interface IProfileService
    {
        ProfileViewModel GetProfileViewModel(string currentUserId);
        EditUserProfileViewModel GetEditProfileViewModel(string currentUserId);
        void EditUser(EditStudentProfileBindingModel editUserProfileBindingModel);
    }
}