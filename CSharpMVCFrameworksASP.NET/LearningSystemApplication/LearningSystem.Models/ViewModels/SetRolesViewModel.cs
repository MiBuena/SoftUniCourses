using System.Collections.Generic;
using LearningSystem.Models.BindingModels;

namespace LearningSystem.Models.ViewModels
{
    public class SetRolesViewModel
    {
        public IList<PersonRoleViewModel> PersonRoles { get; set; }

        public IList<RoleViewModel> AllRoles { get; set; } 
    }
}
