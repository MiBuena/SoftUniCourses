using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }


        public int CompareTo(Person other)
        {
            int namesCompare = this.Name.CompareTo(other.Name);

            if (namesCompare != 0)
            {
                return namesCompare;
            }

            int ageCompare = Convert.ToInt16(this.Age != other.Age);

            if (ageCompare != 0)
            {
                return ageCompare;
            }

            int townsCompare = this.Town.CompareTo(other.Town);

            return townsCompare;




        }
    }
}
