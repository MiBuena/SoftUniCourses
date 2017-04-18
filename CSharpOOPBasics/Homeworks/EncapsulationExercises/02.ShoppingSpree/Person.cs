using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");

                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }
        public List<Product> BagOfProducts { get; set; }

        public bool TryToPurchaseProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                return false;
            }

            this.Money -= product.Cost;
            this.BagOfProducts.Add(product);

            return true;
        }

        public override string ToString()
        {
            string person = $"{this.Name} - ";

            if (this.BagOfProducts.Count == 0)
            {
                person += "Nothing bought";
            }
            else
            {
                person += string.Join(", ", this.BagOfProducts);
            }

            return person;
        }
    }
}
