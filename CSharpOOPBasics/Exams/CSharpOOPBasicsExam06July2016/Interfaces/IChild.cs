using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.KermenExam.Interfaces
{
    public interface IChild
    {
        decimal FoodCost { get; }

        decimal TotalCost { get; }

        ICollection<decimal> ToysCostCollection { get; set; }
    }
}
