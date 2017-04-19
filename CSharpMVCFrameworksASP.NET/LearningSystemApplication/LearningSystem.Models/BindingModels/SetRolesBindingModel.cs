using System.Collections.Generic;
using LearningSystem.Models.ViewModels;

namespace LearningSystem.Models.BindingModels
{
    public class SetRolesBindingModel
    {
        public IList<UserRoleBindingModel> PersonRoles { get; set; }
    }
}
