using System.Data.Entity;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.BindingModels;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels;
using LearningSystem.Services.Interfaces;

namespace LearningSystem.Services.Services
{
    public class ProfileService : Service, IProfileService
    {
        public ProfileViewModel GetProfileViewModel(string currentUserId)
        {
            var student = this.Context.Students.Include(x => x.User).FirstOrDefault(x => x.User.Id == currentUserId);

            var profileViewModel = Mapper.Map<Student, ProfileViewModel>(student);

            return profileViewModel;
        }

        public EditUserProfileViewModel GetEditProfileViewModel(string currentUserId)
        {
            var student = this.Context.Students.FirstOrDefault(x => x.UserId == currentUserId);

            var studentEditProfile = Mapper.Map<Student, EditUserProfileViewModel>(student);

            return studentEditProfile;
        }

        public void EditUser(EditStudentProfileBindingModel editUserProfileBindingModel)
        {
            var student = this.Context.Students.Find(editUserProfileBindingModel.Id);

            var user = this.Context.Users.FirstOrDefault(x => x.Id == editUserProfileBindingModel.UserId);

            this.Context.Entry(student).CurrentValues.SetValues(editUserProfileBindingModel);

            user.Email = editUserProfileBindingModel.Email;

            user.UserName = editUserProfileBindingModel.Username;

            this.Context.SaveChanges();
        }
    }
}

