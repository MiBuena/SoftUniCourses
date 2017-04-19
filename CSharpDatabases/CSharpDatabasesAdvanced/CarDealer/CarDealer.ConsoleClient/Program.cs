using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.ConsoleClient.DTOs;
using CarDealer.Data;
using CarDealer.Data.Repository;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer.ConsoleClient
{
    class Program
    {
        private const string SuppliersPath = "../../../JsonFiles/suppliers.json";

        private const string PartsPath = "../../../JsonFiles/parts.json";

        private const string CarsPath = "../../../JsonFiles/cars.json";

        private const string CustomersPath = "../../../JsonFiles/customers.json";

        private static IList<decimal> Discounts = new decimal[] { 0, 5, 10, 15, 20, 30, 40, 50 };


        static void Main(string[] args)
        {
            CarDealerContext context = new CarDealerContext();

            UnitOfWork unitOfWork = new UnitOfWork();

            //ImportSuppliers(context);

            //ImportParts(context);

            //ImportCars(context);

            //ImportCustomers(context);

            //ImportSales(context);

            //GetOrderedCustomers(context);

            //GetCarsDromMakeToyota(context);

            //GetLocalSuppliers(unitOfWork);

            //GetCarsAndParts(context);

            //GetCustomersAndSales(context);

            //GetSalesWithDiscount(context);
        }

        private static void GetSalesWithDiscount(CarDealerContext context)
        {
            var sales =
                context.Sales.Select(
                    x =>
                        new
                        {
                            car =
                                new
                                {
                                    Make = x.Car.Make,
                                    Model = x.Car.Model,
                                    TravelledDistance = x.Car.TravelledDistance
                                },
                            customerName = x.Customer.Name,
                            Discount = x.DiscountPercentage,
                            price = x.Car.PartsCollection.Sum(y => y.Price),
                            priceWithDiscount = x.Car.PartsCollection.Sum(y => y.Price)*x.DiscountPercentage
                        });

            var salesAsJson = JsonConvert.SerializeObject(sales, Formatting.Indented);

            File.WriteAllText("../../sales-discounts.json", salesAsJson);
        }

        private static void GetCustomersAndSales(CarDealerContext context)
        {
            var customers =
                context.Customers.Where(x => x.Cars.Any())
                    .Select(
                        x =>
                            new
                            {
                                Name = x.Name,
                                boughtCars = x.Cars.Count,
                                spentMoney = x.Cars.Sum(y => y.PartsCollection.Sum(m => m.Price))
                            })
                    .OrderByDescending(g => g.spentMoney)
                    .ThenByDescending(m => m.boughtCars);


            var customersAsJson = JsonConvert.SerializeObject(customers, Formatting.Indented);

            File.WriteAllText("../../customers-total-sales.json", customersAsJson);
        }

        private static void GetCarsAndParts(CarDealerContext context)
        {
            var cars =
                context.Cars.Select(
                    x =>
                        new
                        {
                            car =
                                new
                                {
                                    Make = x.Make,
                                    Model = x.Model,
                                    TravelledDistance = x.TravelledDistance,
                                    Parts = new { Name = x.PartsCollection.Select(y => new { Name = y.Name, Price = y.Price }) }
                                }
                        });


            var carsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);

            File.WriteAllText("../../cars-and-parts.json", carsJson);
        }

        private static void GetLocalSuppliers(UnitOfWork unitOfWork)
        {
            var localSuppliers =
                unitOfWork.PartSupplier.Find(x => !x.IsImporter)
                    .Select(x => new { Id = x.Id, Name = x.Name, NumberOfParts = x.Parts.Count });

            var localSuppliersAsJson = JsonConvert.SerializeObject(localSuppliers, Formatting.Indented);

            File.WriteAllText("../../localSuppliers.json", localSuppliersAsJson);
        }

        private static void GetCarsDromMakeToyota(CarDealerContext context)
        {
            var cars =
                context.Cars.Where(x => x.Make == "Toyota")
                    .OrderBy(x => x.Model)
                    .ThenByDescending(x => x.TravelledDistance);

            var carsAsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);

            File.WriteAllText("../../cars.json", carsAsJson);
        }

        private static void GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers.OrderBy(x => x.DateOfBirth).ThenBy(y => y.IsYoungDriver);

            var customersAsJson = JsonConvert.SerializeObject(customers, Formatting.Indented);

            File.WriteAllText("../../customers.json", customersAsJson);
        }

        private static void ImportCustomers(CarDealerContext context)
        {
            var json = File.ReadAllText(CustomersPath);

            var customers = JsonConvert.DeserializeObject<IEnumerable<CustomerDTO>>(json);

            Random rnd = new Random();

            foreach (var element in customers)
            {
                Customer customer = new Customer()
                {
                    Name = element.Name,
                    DateOfBirth = element.BirthDate,
                    IsYoungDriver = element.IsYoungDriver,
                };

                context.Customers.Add(customer);
            }

            context.SaveChanges();

            foreach (var customer in context.Customers)
            {
                var cars = context.Sales.Where(x => x.Customer.Id == customer.Id).Select(x => x.Car);

                foreach (Car car in cars)
                {
                    customer.Cars.Add(car);

                }


            }

            context.SaveChanges();
        }

        private static void ImportSales(CarDealerContext context)
        {
            Random rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                int carId = rnd.Next(0, context.Cars.Count() + 1);
                int customerId = rnd.Next(0, context.Customers.Count() + 1);
                int discountIndex = rnd.Next(0, 8);

                Car car = context.Cars.FirstOrDefault(x => x.Id == carId);
                Customer customer = context.Customers.FirstOrDefault(x => x.Id == customerId);

                decimal discount = Discounts[discountIndex];


                Sale sale = new Sale()
                {
                    Car = car,
                    Customer = customer,
                    DiscountPercentage = discount
                };

                context.Sales.Add(sale);
            }

            context.SaveChanges();
        }

        private static void ImportCars(CarDealerContext context)
        {
            var json = File.ReadAllText(CarsPath);

            var cars = JsonConvert.DeserializeObject<IEnumerable<CarDTO>>(json);

            Random rnd = new Random();

            foreach (var element in cars)
            {
                Car car = new Car()
                {
                    Make = element.Make,
                    Model = element.Model,
                    TravelledDistance = (long)element.TravelledDistance
                };

                int howManyPartsToAdd = rnd.Next(10, 21);

                for (int i = 0; i < howManyPartsToAdd; i++)
                {
                    int partId = rnd.Next(1, context.Parts.Count() + 1);

                    Part part = context.Parts.FirstOrDefault(x => x.Id == partId);

                    car.PartsCollection.Add(part);
                }

                context.Cars.Add(car);
            }

            context.SaveChanges();
        }

        private static void ImportParts(CarDealerContext context)
        {
            var json = File.ReadAllText(PartsPath);

            var parts = JsonConvert.DeserializeObject<IEnumerable<PartDTO>>(json);

            Random rnd = new Random();

            foreach (var element in parts)
            {
                int supplierId = rnd.Next(1, context.PartSuppliers.Count() + 1);

                PartSupplier partSupplier = context.PartSuppliers.FirstOrDefault(x => x.Id == supplierId);


                Part part = new Part()
                {
                    Name = element.Name,
                    Price = element.Price,
                    Quantity = element.Quantity,
                    PartSupplier = partSupplier
                };

                context.Parts.Add(part);
            }

            context.SaveChanges();
        }

        private static void ImportSuppliers(CarDealerContext context)
        {
            var json = File.ReadAllText(SuppliersPath);

            var suppliers = JsonConvert.DeserializeObject<IEnumerable<PartSupplierDTO>>(json);

            foreach (var element in suppliers)
            {
                PartSupplier partSupplier = new PartSupplier()
                {
                    Name = element.Name,
                    IsImporter = element.IsImporter
                };

                context.PartSuppliers.Add(partSupplier);
            }

            context.SaveChanges();
        }
    }
}
