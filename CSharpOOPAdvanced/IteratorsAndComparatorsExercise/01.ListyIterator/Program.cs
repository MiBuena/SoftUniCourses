using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Book>(new BookComparer());
        }
    }
}
