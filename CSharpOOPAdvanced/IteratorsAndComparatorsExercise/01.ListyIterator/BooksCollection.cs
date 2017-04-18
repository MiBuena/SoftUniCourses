using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    class BooksCollection:IEnumerable<string>
    {
        private List<string> privateCollection;


        public BooksCollection()
        {
            this.privateCollection = new List<string>();
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < this.privateCollection.Count; i++)
            {
                if (i%2 == 1)
                {
                    continue;
                }

                yield return this.privateCollection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
