using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07.ImmutableList
{
    class Program
    {
        static void Main(string[] args)
        {
            Type immutableList = typeof(ImmutableList);
            PropertyInfo[] fields = immutableList.GetProperties();

            if (fields.Length < 1)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(fields.Length);
            }

            MethodInfo[] methods = immutableList.GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
            if (!containsMethod)
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine(methods[2].ReturnType.Name);
            }
        }
    }

    public class ImmutableList
    {
        public ImmutableList()
        {
            this.IntegerCollection = new List<int>();
        }

        public List<int> IntegerCollection { get; set; }

        public ImmutableList GetCollection()
        {
            ImmutableList a = new ImmutableList();

            for (int i = 0; i < this.IntegerCollection.Count; i++)
            {
                a.IntegerCollection.Add(this.IntegerCollection[i]);
            }

            return a;
        }
    }
}
