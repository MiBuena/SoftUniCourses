using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Models.EntityModels
{
    public class Student
    {
        public Student()
        {
            this.CourseRecords = new HashSet<CourseGrade>();
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<CourseGrade> CourseRecords { get; set; }
    }
}
