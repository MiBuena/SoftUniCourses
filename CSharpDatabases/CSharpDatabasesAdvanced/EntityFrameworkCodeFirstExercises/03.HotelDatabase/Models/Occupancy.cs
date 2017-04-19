using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelDatabase.Models
{
    public class Occupancy
    {
        public Occupancy(DateTime dateOccupied, string accountNumber, string roomNumber, decimal rateApplied, decimal phoneCharge): this(dateOccupied, accountNumber, roomNumber, rateApplied, phoneCharge, null)
        {
        }

        public Occupancy(DateTime dateOccupied, string accountNumber, string roomNumber, decimal rateApplied, decimal phoneCharge, string notes)
        {
            DateOccupied = dateOccupied;
            AccountNumber = accountNumber;
            RoomNumber = roomNumber;
            RateApplied = rateApplied;
            PhoneCharge = phoneCharge;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        public DateTime DateOccupied { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string RoomNumber { get; set; }

        [Required]
        public decimal RateApplied { get; set; }

        [Required]
        public decimal PhoneCharge { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }

    }
}
