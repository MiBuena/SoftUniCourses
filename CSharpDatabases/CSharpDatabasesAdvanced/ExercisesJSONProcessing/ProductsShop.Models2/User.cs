using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsShop.Models2
{
    public class User
    {
        public User()
        {
            this.SoldProducts = new List<Product>();
            this.BoughtProducts = new List<Product>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        [MinLength(3)]
        public string LastName { get; set; }

        public int Age { get; set; }

        [InverseProperty("Seller")]
        public virtual ICollection<Product> SoldProducts { get; set; }

        [InverseProperty("Buyer")]
        public virtual ICollection<Product> BoughtProducts { get; set; }

        public virtual ICollection<User> Friends { get; set; }
    }
}
