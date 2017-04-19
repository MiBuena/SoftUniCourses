using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CreateUser.Models
{
    public class Album
    {

        public Album()
        {
            this.Tags = new List<Tag>();
            this.PicturesAlbum = new List<Picture>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string BackgroundColor { get; set; }
        public bool IsPublic { get; set; }
        public User Owner { get; set; }
        public virtual ICollection<Picture> PicturesAlbum { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
