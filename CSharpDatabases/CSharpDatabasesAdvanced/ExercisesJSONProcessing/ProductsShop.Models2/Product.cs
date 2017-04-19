using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsShop.Models2
{
    public class Product
    {

        public Product()
        {
            this.Categories = new HashSet<Category>();
        }

        public int Id { get; set; }

        [MinLength(3)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public User Buyer { get; set; }

        public User Seller { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
