using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningSystem.Data;
using LearningSystem.Models.EntityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningSystem.Services
{
    public class Service
    {
        private LearningSystemContext context;

        private UserManager<ApplicationUser> userManager;

        protected Service()
        {
            this.context = new LearningSystemContext();
            this.userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.Context));

        }

        protected LearningSystemContext Context => this.context;

        protected UserManager<ApplicationUser> UserManager => this.userManager;
    }
}
