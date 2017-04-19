using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CarDealer.Data;

namespace ExportXML
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealerContext context = new CarDealerContext();

            //ExportOrderedCustomers(context);

            //ExtractCarsFromMakeToyota(context);

            //ExtractLocalSuppliers(context);

            //ExtractCarsWithTheirListOfParts(context);

            //ExtractTotalSalesByCustomer(context);

            //ExportSalesWithAppliedDiscount(context);
        }

        private static void ExportSalesWithAppliedDiscount(CarDealerContext context)
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
                            Price = x.Car.PartsCollection.Sum(part => part.Price),
                            PriceWithDiscount = x.Car.PartsCollection.Sum(part => part.Price)*(1 - x.DiscountPercentage/100)
                        });

            var xmlDocument = new XElement("sales");

            foreach (var sale in sales)
            {
                var saleXML = new XElement("sale");

                var car = new XElement("car");

                car.Add(new XAttribute("travelled-distance", sale.car.TravelledDistance));

                car.Add(new XAttribute("model", sale.car.Model));

                car.Add(new XAttribute("make", sale.car.Make));

                var customerName = new XElement("customer-name", sale.customerName);

                var discount = new XElement("discount", sale.Discount);

                var price = new XElement("price", sale.Price);

                var priceWithDiscount = new XElement("price-with-discount", sale.PriceWithDiscount);

                car.Add(customerName);

                car.Add(discount);

                car.Add(price);

                car.Add(priceWithDiscount);

                saleXML.Add(car);

                xmlDocument.Add(saleXML);
            }

            xmlDocument.Save("../../sales-discounts.xml");
        }

        private static void ExtractTotalSalesByCustomer(CarDealerContext context)
        {
            var customers =
                context.Sales.Select(x => x.Customer)
                    .Select(
                        y =>
                            new
                            {
                                Name = y.Name,
                                BoughtCars = y.Sales.Count,
                                TotalMoney =
                                    y.Sales.Sum(g => g.Car.PartsCollection.Sum(part => part.Price*part.Quantity))
                            })
                    .OrderByDescending(x => x.TotalMoney)
                    .ThenByDescending(x => x.BoughtCars);


            var xmlDocument = new XElement("customers");

            foreach (var customer in customers)
            {
                var customerXML = new XElement("customer");

                customerXML.Add(new XAttribute("spent-money", customer.TotalMoney));

                customerXML.Add(new XAttribute("bought-cars", customer.BoughtCars));

                customerXML.Add(new XAttribute("full-name", customer.Name));

                xmlDocument.Add(customerXML);
            }

            xmlDocument.Save("../../customers-total-sales.xml");
        }

        private static void ExtractCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars =
                context.Cars.Select(
                    x =>
                        new
                        {
                            Make = x.Make,
                            Model = x.Model,
                            TravelledDistance = x.TravelledDistance,
                            Parts = x.PartsCollection.Select(y => new { Name = y.Name, Price = y.Price })
                        });

            var xmlDocument = new XElement("cars");

            foreach (var car in cars)
            {
                var carXML = new XElement("car");

                carXML.Add(new XAttribute("travelled-distance", car.TravelledDistance));

                carXML.Add(new XAttribute("model", car.Model));

                carXML.Add(new XAttribute("make", car.Make));

                var parts = new XElement("parts");


                foreach (var part in car.Parts)
                {
                    var partXML = new XElement("part");

                    partXML.Add(new XAttribute("price", part.Price));

                    partXML.Add(new XAttribute("name", part.Name));

                    parts.Add(partXML);
                }
                carXML.Add(parts);


                xmlDocument.Add(carXML);
            }


            xmlDocument.Save("../../cars-and-parts.xml");
        }

        private static void ExtractLocalSuppliers(CarDealerContext context)
        {
            var suppliers =
                context.PartSuppliers.Where(x => !x.IsImporter)
                    .Select(y => new { Id = y.Id, Name = y.Name, NumberOfParts = y.Parts.Count });


            var xmlDocument = new XElement("suppliers");

            foreach (var supplier in suppliers)
            {
                var supplierXML = new XElement("supplier");

                supplierXML.Add(new XAttribute("parts-count", supplier.NumberOfParts));

                supplierXML.Add(new XAttribute("name", supplier.Name));

                supplierXML.Add(new XAttribute("id", supplier.Id));


                xmlDocument.Add(supplierXML);
            }


            xmlDocument.Save("../../local-suppliers.xml");
        }

        private static void ExtractCarsFromMakeToyota(CarDealerContext context)
        {
            var cars =
                context.Cars.Where(x => x.Make == "Toyota")
                    .OrderBy(x => x.Model)
                    .ThenByDescending(x => x.TravelledDistance);

            var xmlDocument = new XElement("cars");

            foreach (var car in cars)
            {
                var carXML = new XElement("car");

                carXML.Add(new XAttribute("travelled-distance", car.TravelledDistance));

                carXML.Add(new XAttribute("model", car.Model));

                carXML.Add(new XAttribute("make", car.Make));

                carXML.Add(new XAttribute("id", car.Id));

                xmlDocument.Add(carXML);
            }

            xmlDocument.Save("../../toyota-cars.xml");
        }

        private static void ExportOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers.OrderBy(x => x.DateOfBirth).ThenBy(x => x.IsYoungDriver);

            var xmlDocument = new XElement("customers");

            foreach (var customer in customers)
            {
                var customerXML = new XElement("customer");

                var id = new XElement("id", customer.Id);

                var name = new XElement("name", customer.Name);

                var birthdate = new XElement("birth-date", customer.DateOfBirth);

                var isYoungDriver = new XElement("is-young-driver", customer.IsYoungDriver);

                customerXML.Add(id);

                customerXML.Add(name);

                customerXML.Add(birthdate);

                customerXML.Add(isYoungDriver);

                xmlDocument.Add(customerXML);
            }

            xmlDocument.Save("../../ordered-customers.xml");
        }
    }
}
