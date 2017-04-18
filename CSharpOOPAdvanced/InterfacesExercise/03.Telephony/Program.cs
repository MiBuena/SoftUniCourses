using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbersToCall = Console.ReadLine().Split(' ').ToArray();

            string[] sitesToVisit = Console.ReadLine().Split(' ').ToArray();

            SmartPhone smartPhone = new SmartPhone();

            for (int i = 0; i < phoneNumbersToCall.Length; i++)
            {
                   Console.WriteLine(smartPhone.Call(phoneNumbersToCall[i]));
            }

            for (int i = 0; i < sitesToVisit.Length; i++)
            {
                Console.WriteLine(smartPhone.Browse(sitesToVisit[i]));
            }
        }
    }
}
