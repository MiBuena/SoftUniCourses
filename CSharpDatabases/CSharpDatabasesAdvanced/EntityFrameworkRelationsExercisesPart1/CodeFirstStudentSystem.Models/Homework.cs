using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentSystem.Models
{
    public class Homework
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string  ContentType { get; set; }

        [Required]
        public DateTime SubmissionDate { get; set; }

        [Required]
        public Student Student { get; set; }

    }
}
