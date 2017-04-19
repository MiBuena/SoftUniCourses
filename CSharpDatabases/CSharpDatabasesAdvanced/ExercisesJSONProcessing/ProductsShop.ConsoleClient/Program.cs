using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProductsShop.Data;
using ProductsShop.Models2;
using ProductsShop.Models2.DTOs;

namespace ProductsShop.ConsoleClient
{
    class Program
    {
        private const string UsersPath = "../../../JsonFiles/users.json";

        private const string ProductsPath = "../../../JsonFiles/products.json";

        private const string CategoriesPath = "../../../JsonFiles/categories.json";


        static void Main(string[] args)
        {
            ProductsShopContext context = new ProductsShopContext();

            context.Products.FirstOrDefault();

            //Task 1: Create Database
            //ImportUsers(context);

            //AddProducts(context);

            //AddCategories(context);

            //AddingCategoriesToProducts(context);

            //Task 2 Products In Range

            //ProductsInRange(context);

            //Task 3 Successfully Sold Products

            //SuccessfullySoldProducts(context);

            //Task 4 Categories By Products Count

            //var categories = context.Categories.Select(y => new { Name = y.Name, NumberOfProducts = y.Products.Count, AveragePriceOfProducts = y.Products.Average(x => x.Price), TotalRevenue = y.Products.Sum(x => x.Price) }).OrderBy(x => x.NumberOfProducts);

            //foreach (var element in categories)
            //{
            //    var planetsAsJson = JsonConvert.SerializeObject(element, Formatting.Indented);

            //    Console.WriteLine(planetsAsJson);
            //}

            //

            //Task 5 Users and Products

            //var users =
            //    context.Users.Where(x => x.SoldProducts.Any())
            //        .OrderByDescending(x => x.SoldProducts.Count)
            //        .ThenBy(y => y.LastName)
            //        .Select(
            //            x => new
            //                {
            //                    FirstName = x.FirstName,
            //                    LastName = x.LastName,
            //                    Age = x.Age,
            //                    Products =
            //                        x.SoldProducts.Select(y => new {ProductName = y.Name, ProductPrice = y.Price})
            //                });

            //Task 6 Users and Products

            //GetUsers(context);
        }

        private static void GetUsers(ProductsShopContext context)
        {
            var users =
                context.Users.Where(x => x.SoldProducts.Any())
                    .OrderByDescending(x => x.SoldProducts.Count)
                    .ThenBy(y => y.LastName)
                    .Select(
                        x => new
                        {
                            FirstName = x.FirstName,
                            LastName = x.LastName,
                            Age = x.Age,
                            Products = new
                            {
                                Count = x.SoldProducts.Count,
                                Prod = x.SoldProducts.Select(y => new {ProductName = y.Name, ProductPrice = y.Price})
                            }
                        });


            var jsonToSerialize = new
            {
                usersCount = users.Count(),
                users = users
            };


            var usersAsJson = JsonConvert.SerializeObject(jsonToSerialize, Formatting.Indented);

            File.WriteAllText("../../users.json", usersAsJson);
        }

        private static void SuccessfullySoldProducts(ProductsShopContext context)
        {
            var products =
                context.Users.Where(x => x.SoldProducts.Any())
                    .Select(
                        y =>
                            new
                            {
                                FirstName = y.FirstName,
                                LastName = y.LastName,
                                SoldProducts =
                                    y.SoldProducts.Select(
                                        x =>
                                            new
                                            {
                                                Name = x.Name,
                                                Price = x.Price,
                                                BuyersFirstName = x.Buyer.FirstName,
                                                BuyersLastName = x.Buyer.LastName
                                            })
                            }).OrderBy(x => x.LastName).ThenBy(x => x.FirstName);

            foreach (var element in products)
            {
                var planetsAsJson = JsonConvert.SerializeObject(element, Formatting.Indented);

                Console.WriteLine(planetsAsJson);
            }
        }

        private static void ProductsInRange(ProductsShopContext context)
        {
            decimal bottomLine = decimal.Parse(Console.ReadLine());

            decimal upperLine = decimal.Parse(Console.ReadLine());


            var products =
                context.Products.Where(x => x.Buyer == null && x.Price > bottomLine && x.Price < upperLine)
                    .Select(
                        z =>
                            new {ProductName = z.Name, Price = z.Price, Seller = z.Seller.FirstName + " " + z.Seller.LastName})
                    .OrderBy(y => y.Price)
                ;


            foreach (var element in products)
            {
                var planetsAsJson = JsonConvert.SerializeObject(element, Formatting.Indented);

                Console.WriteLine(planetsAsJson);
            }
        }

        private static void AddCategories(ProductsShopContext context)
        {
            var json = File.ReadAllText(CategoriesPath);

            var categories = JsonConvert.DeserializeObject<IEnumerable<CategoryDTO>>(json);


            foreach (var element in categories)
            {
                Category category = new Category()
                {
                    Name = element.Name
                };

                context.Categories.Add(category);
            }

            context.SaveChanges();
        }

        private static void AddingCategoriesToProducts(ProductsShopContext context)
        {
            Random rnd = new Random();


            foreach (var element in context.Products)
            {
                int categoryId = rnd.Next(1, 12);

                Category category = context.Categories.FirstOrDefault(x => x.Id == categoryId);

                element.Categories.Add(category);
            }

            context.SaveChanges();
        }

        private static void AddProducts(ProductsShopContext context)
        {
            var json = File.ReadAllText(ProductsPath);

            var products = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(json);

            Random rnd = new Random();


            foreach (var element in products)
            {
                int buyerId = rnd.Next(1, context.Users.Count() + 20);
                int sellerId = rnd.Next(1, context.Users.Count());

                User buyer = context.Users.FirstOrDefault(x => x.Id == buyerId);
                User seller = context.Users.FirstOrDefault(y => y.Id == sellerId);


                Product product = new Product()
                {
                    Buyer = buyer,
                    Name = element.Name,
                    Price = element.Price,
                    Seller = seller
                };

                context.Products.Add(product);
            }

            context.SaveChanges();
        }

        private static void ImportUsers(ProductsShopContext context)
        {
            var json = File.ReadAllText(UsersPath);

            var users = JsonConvert.DeserializeObject<IEnumerable<UserDTO>>(json);

            foreach (var element in users)
            {
                User user = new User()
                {
                    FirstName = element.FirstName,
                    LastName = element.LastName,
                    Age = element.Age,
                };

                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}
