using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.HotelDatabase.Enums;

namespace _03.HotelDatabase.Models
{
    public class RoomType
    {
        public RoomType(TypeOfARoom type) : this(type, null)
        {
        }

        public RoomType(TypeOfARoom type, string notes)
        {
            Type = type;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        public TypeOfARoom Type { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }
    }
}
