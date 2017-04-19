using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CatalogInXMLFormat
{
    class Album
    {

        public Album()
        {
            this.Songs = new HashSet<Song>();
        }

        public string Name { get; set; }

        public string Artist { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

    }
}
