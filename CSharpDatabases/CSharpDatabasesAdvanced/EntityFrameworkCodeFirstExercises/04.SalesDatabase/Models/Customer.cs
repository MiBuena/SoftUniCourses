using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SalesDatabase.Models
{
    public class Customer
    {
        public Customer(string name, string email, string creditCardNumber)
        {
            this.Name = name;
            this.Email = email;
            this.CreditCardNumber = creditCardNumber;
            this.SalesCollection = new List<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }

        public ICollection<Sale> SalesCollection { get; set; }

    }
}
