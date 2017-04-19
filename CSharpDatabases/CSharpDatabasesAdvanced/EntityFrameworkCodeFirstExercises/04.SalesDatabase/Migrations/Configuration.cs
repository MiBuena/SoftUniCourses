using _04.SalesDatabase.Models;

namespace _04.SalesDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_04.SalesDatabase.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_04.SalesDatabase.SalesContext context)
        {
            Customer customer = null;
            if (!context.Customers.Any())
            {
                customer = new Customer("David", "athina@gmail.com", "13242453");

                context.Customers.Add(customer);
            }

            context.SaveChanges();

            Product product = null;
            if (!context.Products.Any())
            {
                product = new Product("Tea", 2M, 2M);

                context.Products.Add(product);
            }

            context.SaveChanges();

            StoreLocation storeLocation = null;

            if (!context.StoreLocations.Any())
            {
                storeLocation = new StoreLocation("Sofia");

                context.StoreLocations.Add(storeLocation);
            }

            if (!context.Sales.Any())
            {
                Sale sale = new Sale(product, customer, storeLocation, DateTime.Now);

                context.Sales.Add(sale);
            }

            context.SaveChanges();



            context.SaveChanges();
        }
    }
}
