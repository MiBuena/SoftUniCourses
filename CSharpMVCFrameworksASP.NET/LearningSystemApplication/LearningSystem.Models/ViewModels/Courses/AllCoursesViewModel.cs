using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningSystem.Models.EntityModels;

namespace LearningSystem.Models.ViewModels.Courses
{
    public class AllCoursesViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name="Trainer Name")]
        public string TrainerName { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Students Count")]
        public int StudentsCount { get; set; }

        public bool CanStudentsSignInAndOut { get; set; }

        public bool HasCurrentUserEnrolledForThisCourse { get; set; }
    }
}
