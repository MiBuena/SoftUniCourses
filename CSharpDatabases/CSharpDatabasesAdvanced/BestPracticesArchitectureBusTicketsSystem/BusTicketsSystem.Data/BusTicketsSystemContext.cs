using BusTicketsSystem.Models;

namespace BusTicketsSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BusTicketsSystemContext : DbContext
    {
        // Your context has been configured to use a 'BusTicketsSystemContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BusTicketsSystem.Data.BusTicketsSystemContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BusTicketsSystemContext' 
        // connection string in the application configuration file.
        public BusTicketsSystemContext()
            : base("name=BusTicketsSystemContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual IDbSet<BusCompany> BusCompanies { get; set; }

        public virtual IDbSet<Ticket> Tickets { get; set; }

        public virtual IDbSet<Customer> Customers { get; set; }

        public virtual IDbSet<Trip> Trips { get; set; }

        public virtual IDbSet<BusStation> BusStations { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<Review> Reviews { get; set; }

        public virtual IDbSet<BankAccount> BankAccounts { get; set; }



    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}