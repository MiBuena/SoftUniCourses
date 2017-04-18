using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    class AddRemoveCollection : IAddToTheBeginning, IRemoveLastItem
    {

        private List<string> collection;

        public AddRemoveCollection()
        {
            this.collection = new List<string>();
        }

        public int AddToTheBeginning(string inputWord)
        {
            this.collection.Insert(0, inputWord);

            return 0;
        }

        public string RemoveLastItem()
        {
            int index = this.collection.Count - 1;

            string removeItem = this.collection[index];

            this.collection.RemoveAt(index);

            return removeItem;
        }
    }
}
