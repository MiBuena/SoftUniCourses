using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.CreateUser.Attributes;

namespace _02.CreateUser.Models
{
    public class Tag
    {

        public int Id { get; set; }

        [Required]
        [Tag]
        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
