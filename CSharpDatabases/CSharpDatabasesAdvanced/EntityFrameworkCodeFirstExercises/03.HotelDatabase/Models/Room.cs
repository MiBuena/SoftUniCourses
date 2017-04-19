using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.HotelDatabase.Enums;

namespace _03.HotelDatabase.Models
{
    public class Room
    {
        public Room(string roomNumber, RoomType roomType, BedType bedType, decimal rate, RoomStatus roomStatus) : this(roomNumber, roomType, bedType, rate, roomStatus, null)
        {
        }

        public Room(string roomNumber, RoomType roomType, BedType bedType, decimal rate, RoomStatus roomStatus, string notes)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            BedType = bedType;
            Rate = rate;
            RoomStatus = roomStatus;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        public string RoomNumber { get; set; }

        [Required]
        public RoomType RoomType { get; set; }

        [Required]
        public BedType BedType { get; set; }

        [Required]
        public decimal Rate { get; set; }

        [Required]
        public RoomStatus RoomStatus { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }

    }
}
