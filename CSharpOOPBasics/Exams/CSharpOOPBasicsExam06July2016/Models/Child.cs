using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class Child : IChild
    {
        public Child(decimal foodCost,  ICollection<decimal> toysCost)
        {
            FoodCost = foodCost;
            ToysCostCollection = new List<decimal>(toysCost);
        }

        public decimal FoodCost { get; }

        public decimal TotalCost
        {
            get
            {
                decimal totalCost = this.FoodCost + this.ToysCostCollection.Sum();

                return totalCost;
            }
        }
        public ICollection<decimal> ToysCostCollection { get; set; }
    }
}
