using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class CustomList<T>:IEnumerable<T> where T:IComparable<T>
    {
        private List<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public void Remove(int index)
        {
            this.data.RemoveAt(index);
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }


        public void SwaptElements(int firstIndex, int secondIndex)
        {
            var firstElementToSwap = this.data[firstIndex];

            this.data[firstIndex] = this.data[secondIndex];

            this.data[secondIndex] = firstElementToSwap;
        }

        public int CountGreaterThan(T element)
        {
            var elements = this.data.Where(x => element.CompareTo(x) < 0);

            return elements.Count();
        }

        public T Max()
        {
            var element = this.data.Max();

            return element;
        }

        public T Min()
        {
            var element = this.data.Min();

            return element;
        }

        public string Print()
        {
            string printing = null;

            foreach (var element in this)
            {
                printing += element + "\n";
            }

            return printing;
        }

        public void Sort()
        {
            this.data.Sort();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
