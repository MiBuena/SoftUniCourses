using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.PersonExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Person gosho = new Person(null, "a", 24);
                Person pesho = new Person("a", "b", 253);


            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine("Exception thrown: {0}", ex.Message);

            }

            Console.WriteLine();
            
            
        }
    }
}
