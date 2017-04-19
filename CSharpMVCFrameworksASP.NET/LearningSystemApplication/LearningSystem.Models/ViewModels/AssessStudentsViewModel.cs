using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningSystem.Models.BindingModels;

namespace LearningSystem.Models.ViewModels
{
    public class AssessStudentsViewModel
    {
        public int CourseId { get; set; }

        public List<GradesViewModel> Grades { get; set; }
    }
}
