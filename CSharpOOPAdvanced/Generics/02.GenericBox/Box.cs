using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericBox
{
    class Box<T> where T:IComparable
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public override string ToString()
        {
            string printing = null;
            foreach (var element in this.data)
            {
                printing += element.GetType().FullName;
                printing += ": ";
                printing += element;

                printing += "\n";

            }
            return printing;

        }

        public int CompareByValue(T element)
        {
            var elements = this.data.Where(x => element.CompareTo(x) < 0);

            return elements.Count();
        }


        public int CompareByValueDouble(T element)
        {
            var elements = this.data.Where(x => element.CompareTo(x) < 0);

            return elements.Count();
        }

        public void SwaptElements(int firstIndex, int secondIndex)
        {
            var firstElementToSwap = this.data[firstIndex];

            this.data[firstIndex] = this.data[secondIndex];

            this.data[secondIndex] = firstElementToSwap;
        }
    }
}
