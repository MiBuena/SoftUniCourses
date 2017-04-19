using System.Web.Mvc;
using LearningSystem.Models.BindingModels;
using LearningSystem.Services.Interfaces;
using Microsoft.AspNet.Identity;

namespace LearningSystemApplication.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private IProfileService service;

        public ProfileController(IProfileService profileService)
        {
            this.service = profileService;
        }

        // GET: Blog/Profile
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();

            var profile = this.service.GetProfileViewModel(currentUserId);

            return View(profile);
        }

        public ActionResult Edit()
        {
            string currentUserId = User.Identity.GetUserId();

            var userProfileViewModel = this.service.GetEditProfileViewModel(currentUserId);

            return View(userProfileViewModel);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,UserId,Name,BirthDate,Username,Email")] EditStudentProfileBindingModel editUserProfileBindingModel)
        {
           if (this.ModelState.IsValid)
           {
                this.service.EditUser(editUserProfileBindingModel);
                return this.RedirectToAction("Index");
            }

            string currentUserId = User.Identity.GetUserId();

            return this.View(this.service.GetEditProfileViewModel(currentUserId));
        }
    }
}