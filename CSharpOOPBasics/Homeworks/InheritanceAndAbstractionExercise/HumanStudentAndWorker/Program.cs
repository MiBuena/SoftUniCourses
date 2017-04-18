using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> a = new List<Student>();

            a.Add(new Student("Pesho", "Minev", "ZHJK678"));
            a.Add(new Student("Gosho", "Minev", "HJKL6789"));
            a.Add(new Student("Alexandra", "Minev", "GHJK678"));
            a.Add(new Student("Vasko", "Minev", "TYUI789"));
            a.Add(new Student("Mancho", "Minev", "UIO7897"));
            a.Add(new Student("Brumcho", "Minev", "HJK789"));

            a = a.OrderBy(x => x.FacultyNumber).ToList();

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].FacultyNumber);
            }

            List<Worker> b = new List<Worker>();

            b.Add(new Worker("P", "R", 300, 4));
            b.Add(new Worker("B", "V", 400, 4));
            b.Add(new Worker("G", "M", 200, 4));
            b.Add(new Worker("M", "K", 100, 4));
            b.Add(new Worker("I", "P", 150, 4));

            b = b.OrderByDescending(x => x.MoneyPerH).ToList();


            for (int i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i].WeekSalary);
            }

            List<Human> c = new List<Human>();

            c.AddRange(a);
            c.AddRange(b);

            c = c.OrderBy(x => x.FirstName).ThenBy(y => y.LastName).ToList();

            Console.WriteLine();

            for (int i = 0; i < c.Count; i++)
            {
                Console.WriteLine(c[i].FirstName);
            }
        }
    }
}
