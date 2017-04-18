using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UniqueStudentNames
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                Student a = new Student(name);
            }

            Console.WriteLine(StudentGroup.Counter);
        }
    }
}
