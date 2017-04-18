using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<Person> peopleCollection = new List<Person>();

            List<Product> productCollection = new List<Product>();

            try
            {
                string people = Console.ReadLine();

                string products = Console.ReadLine();


                List<string> firstDivision =
                    people.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (var element in firstDivision)
                {
                    var a = element.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    string name = a[0];

                    decimal money = decimal.Parse(a[1]);

                    Person p = new Person(name, money);

                    peopleCollection.Add(p);
                }



                List<string> firstProductDivision =
                    products.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (var element in firstProductDivision)
                {
                    var a = element.Split('=').ToList();

                    string name = a[0];

                    decimal price = decimal.Parse(a[1]);

                    Product p = new Product(name, price);

                    productCollection.Add(p);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                while (true)
                {

                    string purchase = Console.ReadLine();

                    if (purchase == "END")
                    {
                        break;
                    }

                    List<string> inputArguments = purchase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    Person buyer = peopleCollection.FirstOrDefault(x => x.Name == inputArguments[0]);

                    Product product = productCollection.FirstOrDefault(y => y.Name == inputArguments[1]);

                    if (buyer != null && product != null)
                    {
                        bool successfullPurchase = buyer.TryToPurchaseProduct(product);

                        if (successfullPurchase)
                        {
                            Console.WriteLine($"{buyer.Name} bought {product.Name}");
                        }
                        else
                        {
                            Console.WriteLine(String.Format("{0} can't afford {1}", buyer.Name, product.Name));
                        }
                    }

                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            foreach (var element in peopleCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
