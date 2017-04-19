using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SalesDatabase.Models
{
    public class Sale
    {
        public Sale(Product product, Customer customer, StoreLocation storeLocation, DateTime date)
        {
            this.Product = product;
            this.Customer = customer;
            this.StoreLocation = storeLocation;
            this.Date = date;
        }

        public int Id { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public DateTime Date { get; set; }
    }
}
