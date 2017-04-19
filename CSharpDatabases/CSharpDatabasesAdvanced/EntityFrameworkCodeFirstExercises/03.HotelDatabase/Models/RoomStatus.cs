using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.HotelDatabase.Enums;

namespace _03.HotelDatabase.Models
{
    public class RoomStatus
    {
        public RoomStatus(StatusOfARoom status) : this(status, null)
        {

        }
        public RoomStatus(StatusOfARoom status, string notes)
        {
            Status = status;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        public StatusOfARoom Status { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }
    }
}
