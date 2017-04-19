using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.ComponentModel.DataAnnotations;


namespace _01.GringottsDatabase
{
    public class WizardDeposit
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(60)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(1000)]
        public string Notes { get; set; }

        [Required]
        public uint Age { get; set; }

        [MaxLength(100)]
        public string MagicWandCreator { get; set; }

        public short MagicWandSize { get; set; }

        [MaxLength(20)]
        public string DepositGroup { get; set; }

        public DateTime DepositStartDate { get; set; }

        public decimal DepositAmount { get; set; }

        public decimal DepositInterest { get; set; }

        public decimal DepositCharge { get; set; }

        public DateTime DepositExpirationDate { get; set; }

        public bool IsDepositExpired { get; set; }


    }
}
