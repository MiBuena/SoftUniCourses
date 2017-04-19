using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningSystem.Models.EntityModels;

namespace LearningSystem.Models.ViewModels
{
    public class ProfileViewModel
    {
        public string Name { get; set; }

        public ICollection<CourseGrade> Grades { get; set; }
    }
}
