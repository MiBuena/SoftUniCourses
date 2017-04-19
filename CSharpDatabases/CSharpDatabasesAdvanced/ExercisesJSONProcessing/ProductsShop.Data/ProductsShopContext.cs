using System.Runtime.Remoting.Contexts;
using ProductsShop.Data.Migrations;
using ProductsShop.Models2;

namespace ProductsShop.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductsShopContext : DbContext
    {
        // Your context has been configured to use a 'ProductsShopContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ProductsShop.Data.ProductsShopContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ProductsShopContext' 
        // connection string in the application configuration file.
        public ProductsShopContext()
            : base("name=ProductsShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductsShopContext, Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Product> Products { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(st => st.Friends)
                .WithMany();

            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}