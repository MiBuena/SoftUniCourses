using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Models.ViewModels
{
    public class PersonRoleViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string NewRoleName { get; set; }

        [Display(Name = "Current roles")]
        public List<RoleViewModel> CurrentRoleViewModels { get; set; }
        
    }
}
