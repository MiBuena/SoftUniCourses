using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CreateUser.Models
{
    public class Picture
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Caption { get; set; }

        [Required]
        public string Path{ get; set; }

        [MaxLength(1024 * 1024)]
        public byte[] ProfilePicture { get; set; }

        public virtual ICollection<Album> Albums { get; set; } 
    }
}
