using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UniqueStudentNames
{
    class Student
    {
        public Student(string name)
        {
            this.Name = name;
            StudentGroup.UpdateStudentNames(name);
        }

        public string Name { get; set; }
    }
}
