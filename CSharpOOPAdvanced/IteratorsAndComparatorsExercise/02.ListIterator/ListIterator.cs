using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ListIterator
{
    class ListIterator<T>:IEnumerable<T>
    {
        private List<T> data;

        private int index;

        public ListIterator(List<T> data )
        {
            this.data = data;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.index + 1 >= this.data.Count)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("Invalid operation");
            }

            Console.WriteLine(this.data[this.index]);

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
