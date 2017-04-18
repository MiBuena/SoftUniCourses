using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    class AddCollection : IAddToTheEnd
    {
        private List<string> collection;

        public AddCollection()
        {
            this.collection = new List<string>();
        } 
        public int AddToTheEnd(string inputWord)
        {
            this.collection.Add(inputWord);

            int index = this.collection.Count - 1;

            return index;
        }
    }
}
