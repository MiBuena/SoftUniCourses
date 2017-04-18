using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    class Stack<T>:IEnumerable<T>
    {
        private List<T> data;

        public Stack()
        {
            this.data = new List<T>();
        }

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public T Pop()
        {
            if (this.data.Count==0)
            {
                throw new ArgumentException("No elements");
            }

            var popElement = this.data.LastOrDefault();

            this.data.Remove(popElement);

            return popElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count-1; i >= 0; i--)
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
