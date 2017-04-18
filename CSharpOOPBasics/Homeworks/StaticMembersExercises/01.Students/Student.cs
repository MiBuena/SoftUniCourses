using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students
{
    class Student
    {

        static Student()
        {
            Student.Counter = 0;
        }

        public Student(string name)
        {
            this.Name = name;
            Student.Counter++;
        }

        public string Name { get; set; }

        public static int Counter { get; set; }
    }
}
