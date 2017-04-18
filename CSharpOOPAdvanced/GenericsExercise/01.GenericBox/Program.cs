using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomData<int> data = new MyCustomData<int>();

            data.Add(1);
        }
    }
}
