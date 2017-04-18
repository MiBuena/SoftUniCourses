using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitten a = new Kitten("Kitten", 20);

            Console.WriteLine(a.Gender);
            a.Gender = Gender.Female;

            List<Animal> b = new List<Animal>();

            b.Add(new Kitten("A", 10));
            b.Add(new Cat("Cat", 5, Gender.Female));
            b.Add(new Dog("A", 3, Gender.Male));

            double c = b.Average(x => x.Age);

            Console.WriteLine(c);
        }
    }
}
