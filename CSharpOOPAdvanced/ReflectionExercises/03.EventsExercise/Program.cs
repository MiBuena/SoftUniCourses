using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EventsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                Name = "Ivan"
            };

            var anotherStudent = new Student()
            {
                Name = "Gosho"
            };

            var thirdStudent = new Student()
            {
                Name = "Pesho"
            };

            var teacher = new Teacher()
            {
                Name = "g-n Peshov"
            };

            student.AttendClass(teacher);

            anotherStudent.AttendClass(teacher);

            teacher.StartClass("Math");
        }
    }
}
