using System.Runtime.Remoting.Contexts;
using BookShopSystem.Data.Migrations;
using Models;

namespace BookShopSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookShopContext : DbContext
    {
        // Your context has been configured to use a 'BookShopContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookShopSystem.Data.BookShopContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BookShopContext' 
        // connection string in the application configuration file.
        public BookShopContext()
            : base("name=BookShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookShopContext, Configuration>());
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
                           .HasMany(st => st.RelatedBooks)
                           .WithMany()

            .Map(cs =>
             {
                 cs.MapLeftKey("BookId");
                 cs.MapRightKey("RelatedBookId");
                 cs.ToTable("RelatedBooks");
             });


            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}