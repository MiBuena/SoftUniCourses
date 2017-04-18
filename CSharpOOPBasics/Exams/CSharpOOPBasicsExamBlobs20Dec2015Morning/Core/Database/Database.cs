using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Blobs.Interfaces;

namespace _01.Blobs.Database
{
    public class Database : IDatabase
    {
        public Database()
        {
            this.BlobsCollection = new List<IBlob>();
        }

        public IList<IBlob> BlobsCollection { get; set; }
    }
}
