using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LettersSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string alphabetSmall = "abcdefghijklmnopqrstuvwxyz";
            string alphabetBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string third = "`~!@#$%^&*()_+{}:\"|<>?-=[];'\\,./";
            

            int sumLetters = 0;
            int sumNumbers = 0;
            int sumThird = 0;

            string p = null;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                sb.Append(a);

            }

            p = sb.ToString();

            for (int i = 0; i < p.Length; i++)
            {
                if ((alphabetBig.Contains(p[i].ToString())))
                {
                    int g = alphabetBig.IndexOf(p[i]);
                    sumLetters+=(g+1)*10;
                }
                else if((alphabetSmall.Contains(p[i])))
                {
                    int g = alphabetSmall.IndexOf(p[i]);
                    sumLetters+=(g+1)*10;
                }
                else if (numbers.Contains(p[i]))
                {
                    int num = int.Parse(p[i].ToString());
                    sumNumbers += num*20;
                }
                else if (p[i].ToString() == " ")
                {
                    
                }
                else if(third.Contains(p[i].ToString()))
                {
                    sumThird += 200;
                }
            }

            Console.WriteLine(sumLetters);
            Console.WriteLine(sumNumbers);
            Console.WriteLine(sumThird);
            
        }
    }
}
