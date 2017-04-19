using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateStudentsXMLDocument
{
    class Student
    {

        public Student()
        {
            this.Exams = new HashSet<Exam>();
        }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string University { get; set; }

        public string Specialty { get; set; }

        public string FacultyNumber  { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }


    }
}
