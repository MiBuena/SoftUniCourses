using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Models.ViewModels.Courses
{
    public class AddNewCourseViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<TrainerViewModel> TrainerViewModels { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
