using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using ProductsShop.Data;
using ProductsShop.Models2;

namespace ProductsShop.XML
{
    class Program
    {
        private const string UsersPath = "../../../XMLDocuments/users.xml";
        private const string CategoriesPath = "../../../XMLDocuments/categories.xml";
        private const string ProductsPath = "../../../XMLDocuments/products.xml";


        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ProductsShopContext context = new ProductsShopContext();

            //ImportUsers(context);

            //ImportCategories(context);

            //ImportProducts(context);

            //ExportProductsInRange(context);

            //GetSuccessfullySoldProducts(context);

            //GetCategoriesByProductsCount(context);

            //ExtractUsersAndProducts(context);
        }

        private static void ExtractUsersAndProducts(ProductsShopContext context)
        {
            var users =
                context.Users.Where(x => x.SoldProducts.Any())
                    .OrderByDescending(y => y.SoldProducts.Count)
                    .ThenBy(y => y.LastName)
                    .Select(
                        m =>
                            new
                            {
                                FirstName = m.FirstName,
                                LastName = m.LastName,
                                Age = m.Age,
                                Products = m.SoldProducts.Select(x => new {Name = x.Name, Price = x.Price})
                            });


            var xmlDocument = new XElement("users");
            xmlDocument.Add(new XAttribute("Count", users.Count()));

            foreach (var user in users)
            {
                var userXML = new XElement("user");

                userXML.Add(new XAttribute("first-name", user.FirstName ?? " "));

                userXML.Add(new XAttribute("last-name", user.LastName ?? " "));

                userXML.Add(new XAttribute("age", user.Age));

                var soldProducts = new XElement("sold-products");

                soldProducts.Add(new XAttribute("count", user.Products.Count()));

                foreach (var product in user.Products)
                {
                    var productXML = new XElement("product");

                    productXML.Add(new XAttribute("name", product.Name ?? " "));

                    productXML.Add(new XAttribute("price", product.Price));

                    soldProducts.Add(productXML);
                }

                userXML.Add(soldProducts);

                xmlDocument.Add(userXML);
            }

            xmlDocument.Save("../../users-and-products.xml");
        }

        private static void GetCategoriesByProductsCount(ProductsShopContext context)
        {
            var categories =
                context.Categories.OrderBy(x => x.Products.Count)
                    .Select(
                        m =>
                            new
                            {
                                Name = m.Name,
                                ProductsCount = m.Products.Count(),
                                AveragePrice = m.Products.Average(y => y.Price),
                                TotalRevenue = m.Products.Sum(x => x.Price)
                            });

            var xmlDocument = new XElement("categories");

            foreach (var category in categories)
            {
                var categoryXML = new XElement("category");

                categoryXML.Add(new XAttribute("name", category.Name));

                var productsCount = new XElement("products-count", category.ProductsCount);

                var averagePrice = new XElement("average-price", category.AveragePrice);

                var totalRevenue = new XElement("total-revenue", category.TotalRevenue);

                categoryXML.Add(totalRevenue);
                categoryXML.Add(productsCount);
                categoryXML.Add(averagePrice);

                xmlDocument.Add(categoryXML);
            }


            xmlDocument.Save("../../categories-by-products.xml");
        }

        private static void GetSuccessfullySoldProducts(ProductsShopContext context)
        {
            var users =
                context.Users.Where(x => x.SoldProducts.Any())
                    .OrderBy(x => x.LastName)
                    .ThenBy(x => x.FirstName)
                    .Select(
                        y =>
                            new
                            {
                                FirstName = y.FirstName,
                                LastName = y.LastName,
                                SoldProducts =
                                    y.SoldProducts.Select(
                                        m =>
                                            new
                                            {
                                                Name = m.Name,
                                                Price = m.Price,
                                                Buyer = new {FirstName = m.Buyer.FirstName, LastName = m.Buyer.LastName}
                                            })
                            });

            var xmlDocument = new XElement("users");


            foreach (var user in users)
            {
                var userXML = new XElement("user");

                userXML.Add(new XAttribute("first-name", user.FirstName ?? " "));

                userXML.Add(new XAttribute("last-name", user.LastName ?? " "));

                var soldProducts = new XElement("sold-products");


                foreach (var product in user.SoldProducts)
                {
                    var newProduct = new XElement("product");

                    var productName = new XElement("name", product.Name ?? " ");

                    var price = new XElement("price", product.Price);

                    var buyerFirstName = new XElement("buyer-first-name", product.Buyer.FirstName ?? " ");

                    var buyerLastName = new XElement("buyer-last-name", product.Buyer.LastName ?? " ");

                    newProduct.Add(productName);
                    newProduct.Add(price);
                    newProduct.Add(buyerFirstName);
                    newProduct.Add(buyerLastName);

                    soldProducts.Add(newProduct);
                }

                userXML.Add(soldProducts);

                xmlDocument.Add(userXML);
            }

            xmlDocument.Save("../../users-sold-products.xml");
        }

        private static void ExportProductsInRange(ProductsShopContext context)
        {
            decimal lowerBorder = decimal.Parse(Console.ReadLine());

            decimal upperBorder = decimal.Parse(Console.ReadLine());

            var products =
                context.Products.Where(x => x.Price >= lowerBorder && x.Price <= upperBorder && x.Buyer == null)
                    .OrderBy(x => x.Price)
                    .Select(
                        y => new {Name = y.Name, Price = y.Price, Seller = y.Seller.FirstName + " " + y.Seller.LastName});

            var xmlDocument = new XElement("products");

            foreach (var element in products)
            {
                var product = new XElement("product");

                product.Add(new XAttribute("name", element.Name));

                product.Add(new XAttribute("price", element.Price));

                product.Add(new XAttribute("seller", element.Seller));

                xmlDocument.Add(product);
            }

            xmlDocument.Save("../../products-in-range.xml");
        }

        private static void ImportProducts(ProductsShopContext context)
        {
            var xml = XDocument.Load(ProductsPath);

            var products = xml.XPathSelectElements("products").Elements("product");


            Random rnd = new Random();

            foreach (var product in products)
            {
                string productName = null;
                decimal newPrice = 0m;

                foreach (var name in product.Elements("name"))
                {
                    productName = name.Value;
                }

                foreach (var price in product.Elements("price"))
                {
                    newPrice = decimal.Parse(price.Value);
                }

                Product newProduct = new Product()
                {
                    Name = productName,
                    Price = newPrice
                };

                int sellerId = rnd.Next(1, context.Users.Count());

                int buyerId = rnd.Next(1, context.Users.Count() + 20);

                int categoryId = rnd.Next(1, context.Categories.Count());

                User seller = context.Users.FirstOrDefault(x => x.Id == sellerId);

                User buyer = context.Users.FirstOrDefault(x => x.Id == buyerId);

                Category category = context.Categories.FirstOrDefault(x => x.Id == categoryId);

                newProduct.Buyer = buyer;
                newProduct.Seller = seller;
                newProduct.Categories.Add(category);


                context.Products.Add(newProduct);
            }

            context.SaveChanges();
        }

        private static void ImportCategories(ProductsShopContext context)
        {
            var xml = XDocument.Load(CategoriesPath);

            var categories = xml.XPathSelectElements("categories").Elements("category").Elements("name");


            foreach (var category in categories)
            {
                string categoryName = category.Value;

                Category newCategory = new Category()
                {
                    Name = categoryName
                };

                context.Categories.Add(newCategory);
            }

            context.SaveChanges();
        }

        private static void ImportUsers(ProductsShopContext context)
        {
            var xml = XDocument.Load(UsersPath);

            var users = xml.XPathSelectElements("users");

            foreach (var user in users.Descendants("user"))
            {
                string firstName = null;
                string lastName = null;
                int age = 0;

                if (user.Attributes().Any(x => x.Name == "first-name"))
                {
                    firstName = user.Attributes().FirstOrDefault(x => x.Name == "first-name").Value;
                }


                if (user.Attributes().Any(x => x.Name == "last-name"))
                {
                    lastName = user.Attributes().FirstOrDefault(x => x.Name == "last-name").Value;
                }

                if (user.Attributes().Any(x => x.Name == "age"))
                {
                    age = int.Parse(user.Attributes().FirstOrDefault(x => x.Name == "age").Value);
                }

                User userDB = new User()
                {
                    Age = age,
                    FirstName = firstName,
                    LastName = lastName
                };

                context.Users.Add(userDB);
            }

            context.SaveChanges();
        }
    }
}
