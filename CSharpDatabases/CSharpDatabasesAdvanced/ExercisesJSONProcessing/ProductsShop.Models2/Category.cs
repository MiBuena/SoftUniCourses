using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsShop.Models2
{
    public class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
