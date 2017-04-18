using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern
{
    class SecondComparer:IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = 0;

            if (x.Age < y.Age)
            {
                result = -1;
                return result;
            }
            else if (x.Age == y.Age)
            {
                return result;
            }
            else
            {
                result = 1;
                return result;
            }
        }
    }
}
