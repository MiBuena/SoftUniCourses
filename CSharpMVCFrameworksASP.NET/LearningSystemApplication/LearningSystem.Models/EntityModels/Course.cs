using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Models.EntityModels
{
    public class Course
    {

        public Course()
        {
            this.CourseRecords = new HashSet<CourseGrade>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public virtual ApplicationUser Trainer { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }


        public bool CanStudentsSignInAndOut
        {
            get { return DateTime.Now >= this.StartDate && DateTime.Now <= this.EndDate; }
        }

        public virtual ICollection<CourseGrade> CourseRecords { get; set; }

    }
}
