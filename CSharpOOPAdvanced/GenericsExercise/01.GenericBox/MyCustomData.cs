using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBox
{
    public class MyCustomData<T>
    {
        private List<T> data;

        public MyCustomData()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T this[int index]
        {
            get { return this.data[index]; }
        }

        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
    }
}
