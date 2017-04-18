using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    class Lake<T> : IEnumerable<T>
    {
        private List<T> data;

        public Lake(List<T> data)
        {
            this.data = data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i+=2)
            {
                yield return this.data[i];
            }

            var collection = this.data.Where((c, i) => i % 2 != 0).Reverse().ToList();

            for (int i = 0; i < collection.Count; i ++)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
