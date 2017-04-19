using System.Runtime.Remoting.Contexts;
using CarDealer.Data.Migrations;
using CarDealer.Models;

namespace CarDealer.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarDealerContext : DbContext
    {
        // Your context has been configured to use a 'CarDealerContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CarDealer.Data.CarDealerContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CarDealerContext' 
        // connection string in the application configuration file.
        public CarDealerContext()
            : base("name=CarDealerContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarDealerContext, Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<Customer> Customers { get; set; }

        public virtual IDbSet<Part> Parts { get; set; }

        public virtual IDbSet<PartSupplier> PartSuppliers { get; set; }

        public virtual IDbSet<Sale> Sales { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}