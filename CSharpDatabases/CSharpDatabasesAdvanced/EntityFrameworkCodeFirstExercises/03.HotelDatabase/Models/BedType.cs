using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.HotelDatabase.Enums;

namespace _03.HotelDatabase.Models
{
    public class BedType
    {
        public BedType(TypeOfABed typeOfABed): this(typeOfABed, null)
        {
        }

        public BedType(TypeOfABed typeOfABed, string notes)
        {
            TypeOfABed = typeOfABed;
            Notes = notes;
        }


        public int Id { get; set; }
        
        [Required]
        public TypeOfABed TypeOfABed { get; set; }

        [MaxLength(200)]
        public string Notes { get; set; }
    }
}
