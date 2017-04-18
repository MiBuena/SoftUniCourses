using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern
{
    class FirstComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int nameLength = 0;

            if (x.Name.Length < y.Name.Length)
            {
                nameLength = -1;
            }

            if (x.Name.Length > y.Name.Length)
            {
                nameLength = 1;
            }

            if (nameLength != 0)
            {
                return nameLength;
            }

            int firstLetter = x.Name[0].ToString().ToUpper().CompareTo(y.Name[0].ToString().ToUpper());


            return firstLetter;
        }
    }
}
