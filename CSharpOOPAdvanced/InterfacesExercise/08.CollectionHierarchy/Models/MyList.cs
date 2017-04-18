using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    class MyList : IAddToTheBeginning, IRemoveFirstItem, IInformationProviding
    {
        private List<string> collection;

        public MyList()
        {
            this.collection = new List<string>();
        }

        public int AddToTheBeginning(string inputWord)
        {
            this.collection.Insert(0, inputWord);

            return 0;
        }

        public string RemoveFirstItem()
        {
            string itemToRemove = this.collection[0];

            this.collection.RemoveAt(0);

            return itemToRemove;
        }

        public int Used { get; set; }
    }
}
