using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AttemptsAtReflection
{
    class Cat
    {
        private string name;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        [Author(Name = "The best")]
        public string Name {
            get { return this.name; }
        set { this.name = value; } }

        public int Age { get; set; }


        public void Hello()
        {
            Console.WriteLine("Hello");
        }

    }
}
