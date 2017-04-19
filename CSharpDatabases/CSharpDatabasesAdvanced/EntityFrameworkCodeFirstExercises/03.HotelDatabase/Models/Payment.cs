using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelDatabase.Models
{
    public class Payment
    {
        public Payment(DateTime paymentDate, string accountNumber, DateTime firstDateOccupied, DateTime lastDateOccupied, decimal amountCharged, decimal taxRate):this(paymentDate, accountNumber, firstDateOccupied, lastDateOccupied, amountCharged, taxRate, null)
        {
        }

        public Payment(DateTime paymentDate, string accountNumber, DateTime firstDateOccupied, DateTime lastDateOccupied, decimal amountCharged, decimal taxRate, string notes)
        {
            PaymentDate = paymentDate;
            AccountNumber = accountNumber;
            FirstDateOccupied = firstDateOccupied;
            LastDateOccupied = lastDateOccupied;
            AmountCharged = amountCharged;
            TaxRate = taxRate;
            Notes = notes;
        }

        public int Id { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public DateTime FirstDateOccupied { get; set; }

        [Required]
        public DateTime LastDateOccupied { get; set; }

        public int TotalDays
        {
            get { return (int)(this.FirstDateOccupied - this.LastDateOccupied).TotalDays; }
        }

        [Required]
        public decimal AmountCharged { get; set; }

        [Required]
        public decimal TaxRate { get; set; }

        public decimal TaxAmount
        {
            get { return (1 + this.TaxRate)*this.AmountCharged*this.TotalDays; }
        }

        public decimal PaymentTotal
        {
            get { return this.TaxAmount+this.AmountCharged*this.TotalDays; }
        }

        [MaxLength(200)]
        public string Notes { get; set; }

    }
}
