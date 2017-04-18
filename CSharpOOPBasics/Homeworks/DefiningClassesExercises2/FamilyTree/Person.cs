using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    class Person
    {
        public Person(string name) : this(name, default(DateTime))
        {
        }

        public Person(DateTime birthday):this(null, birthday)
        {
        }

        public Person(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        public override string ToString()
        {
            string person = string.Format("{0} {1} \nParents:", this.Name, this.Birthday.ToString("d/M/yyyy", CultureInfo.InvariantCulture));

            foreach (var element in this.Parents)
            {
                person += String.Format("\n{0} {1}", element.Name, element.Birthday.ToString("d/M/yyyy", CultureInfo.InvariantCulture));
            }

            person += "\nChildren:";
            foreach (var element in this.Children)
            {
                person += String.Format("\n{0} {1}", element.Name, element.Birthday.ToString("d/M/yyyy", CultureInfo.InvariantCulture));
            }



            return person;
        }
    }
}
