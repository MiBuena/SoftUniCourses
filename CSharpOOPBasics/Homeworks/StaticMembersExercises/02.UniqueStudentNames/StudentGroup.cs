using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UniqueStudentNames
{
    class StudentGroup
    {
        public static int Counter { get; set; }
        public static HashSet<string> UniqueStudentNames { get; set; }


        static StudentGroup()
        {
            StudentGroup.UniqueStudentNames = new HashSet<string>();
        }

        public static void UpdateStudentNames(string name)
        {
            if (!StudentGroup.UniqueStudentNames.Contains(name))
            {
                UniqueStudentNames.Add(name);

                StudentGroup.Counter = UniqueStudentNames.Count;
            }
        }
    }
}
