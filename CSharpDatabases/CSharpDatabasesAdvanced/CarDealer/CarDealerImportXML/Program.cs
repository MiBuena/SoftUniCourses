using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using CarDealer.Data;
using CarDealer.Models;

namespace CarDealerImportXML
{
    class Program
    {
        private const string SuppliersPath = "../../../XMLDocuments/suppliers.xml";

        private const string PartsPath = "../../../XMLDocuments/parts.xml";

        private const string CarsPath = "../../../XMLDocuments/cars.xml";

        private const string CustomersPath = "../../../XMLDocuments/customers.xml";

        private static int[] discountsArray = new int[]
        {
            0,5,10,15,20,30,40,50
        };
         
        static void Main(string[] args)
        {
            CarDealerContext context = new CarDealerContext();
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            //ImportSuppliers(context);

            //ImportParts(context);

            //ImportCars(context);

            //ImportCustomers(context);

           //ImportSales(context);
        }

        private static void ImportSales(CarDealerContext context)
        {
            Random rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                int customerId = rnd.Next(1, context.Customers.Count() + 1);
                int carId = rnd.Next(1, context.Cars.Count() + 1);
                int discountPosition = rnd.Next(0, discountsArray.Length + 1);

                Car carToAdd = context.Cars.FirstOrDefault(x => x.Id == carId);
                Customer customerToAdd = context.Customers.FirstOrDefault(x => x.Id == customerId);

                Sale saleToAdd = new Sale()
                {
                    Car = carToAdd,
                    Customer = customerToAdd,
                    DiscountPercentage = discountsArray[discountPosition]
                };

                context.Sales.Add(saleToAdd);
            }

            context.SaveChanges();
        }

        private static void ImportCustomers(CarDealerContext context)
        {
            var xml = XDocument.Load(CustomersPath);

            var customers = xml.XPathSelectElements("customers").Elements("customer");

            foreach (var customer in customers)
            {
                string name = customer.Attribute("name").Value;

                DateTime birthdate = DateTime.Parse(customer.Element("birth-date").Value);

                bool isYoungDriver = bool.Parse(customer.Element("is-young-driver").Value);

                Customer customerToAdd = new Customer()
                {
                    Name = name,
                    DateOfBirth = birthdate,
                    IsYoungDriver = isYoungDriver
                };


                context.Customers.Add(customerToAdd);
            }


            context.SaveChanges();
        }

        private static void ImportCars(CarDealerContext context)
        {
            var xml = XDocument.Load(CarsPath);

            var cars = xml.XPathSelectElements("cars").Elements("car");

            Random rnd = new Random();

            foreach (var car in cars)
            {
                string make = car.Element("make").Value;

                string model = car.Element("model").Value;

                long travelledDistance = long.Parse(car.Element("travelled-distance").Value);

                int numberOfParts = rnd.Next(10, 21);

                Car carToAdd = new Car()
                {
                    Make = make,
                    Model = model,
                    TravelledDistance = travelledDistance
                };

                for (int i = 0; i < numberOfParts; i++)
                {
                    int partId = rnd.Next(1, context.Parts.Count() + 1);

                    Part part = context.Parts.FirstOrDefault(x => x.Id == partId);

                    carToAdd.PartsCollection.Add(part);
                }

                context.Cars.Add(carToAdd);
            }

            context.SaveChanges();
        }

        private static void ImportParts(CarDealerContext context)
        {
            var xml = XDocument.Load(PartsPath);

            var parts = xml.XPathSelectElements("parts").Elements("part");

            Random rnd = new Random();

            foreach (var part in parts)
            {
                string name = part.Attribute("name").Value;

                decimal price = decimal.Parse(part.Attribute("price").Value);

                int quantity = int.Parse(part.Attribute("quantity").Value);

                int supplierId = rnd.Next(1, context.PartSuppliers.Count() + 1);

                PartSupplier supplier = context.PartSuppliers.FirstOrDefault(x => x.Id == supplierId);


                Part newPart = new Part()
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    PartSupplier = supplier
                };


                context.Parts.Add(newPart);
            }

            context.SaveChanges();
        }

        private static void ImportSuppliers(CarDealerContext context)
        {
            var xml = XDocument.Load(SuppliersPath);

            var suppliers = xml.XPathSelectElements("suppliers").Elements("supplier");

            foreach (var supplier in suppliers)
            {
                string name = supplier.Attribute("name").Value;
                bool isImporter = bool.Parse(supplier.Attribute("is-importer").Value);

                PartSupplier supplierToAdd = new PartSupplier()
                {
                    Name = name,
                    IsImporter = isImporter
                };

                context.PartSuppliers.Add(supplierToAdd);
            }


            context.SaveChanges();
        }
    }
}
