using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SalesDatabase.Models
{
    public class Product
    {
        public Product(string name, decimal quantity, decimal price)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.SalesCollection = new List<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public ICollection<Sale> SalesCollection { get; set; } 
    }
}
