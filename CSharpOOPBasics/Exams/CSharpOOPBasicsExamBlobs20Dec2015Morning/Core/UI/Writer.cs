using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.UI
{
    public class Writer : IWriter
    {
        public void WriteLine(string message)
        {
            Console.Write(message);
        }
    }
}
