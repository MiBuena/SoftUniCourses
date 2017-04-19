using System.Globalization;
using System.IO;
using Models;
using Models.Enumerations;

namespace BookShopSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<BookShopSystem.Data.BookShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BookShopSystem.Data.BookShopContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookShopSystem.Data.BookShopContext context)
        {
            if (!context.Authors.Any())
            {
                string path = @"C:\Users\ff\Downloads\04. DB-Advanced-EntityFramework-Code-First-Exercise-Book-Shop-Part-1 (1)\04. DB-Advanced-EntityFramework-Code-First-Exercise-Book-Shop-Part-1\authors.txt";
                using (var reader = new StreamReader(path))
                {
                    var line = reader.ReadLine();

                    while (true)
                    {
                        line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        var data = line.Split(new[] {' '});
                        string firstName = data[0];

                        string lastName = data[1];

                        Author author = new Author()
                        {
                            FirstName = firstName,
                            LastName = lastName
                        };

                        context.Authors.Add(author);
                    }
                }
            }

            if (!context.Category.Any())
            {
                string path = @"C:\Users\ff\Downloads\04. DB-Advanced-EntityFramework-Code-First-Exercise-Book-Shop-Part-1 (1)\04. DB-Advanced-EntityFramework-Code-First-Exercise-Book-Shop-Part-1\categories.txt";
                using (var reader = new StreamReader(path))
                {
                    var line = reader.ReadLine();

                    while (true)
                    {
                        line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        Category category = new Category()
                        {
                            Name = line
                        };

                        context.Category.Add(category);
                    }
                }
            }

            if (!context.Books.Any())
            {
                string path = @"C:\Users\ff\Downloads\04. DB-Advanced-EntityFramework-Code-First-Exercise-Book-Shop-Part-1 (1)\04. DB-Advanced-EntityFramework-Code-First-Exercise-Book-Shop-Part-1\books.txt";

                Random random = new Random();

                using (var reader = new StreamReader(path))
                {
                    var line = reader.ReadLine();
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        var data = line.Split(new[] { ' ' }, 6);
                        var authorIndex = random.Next(0, context.Authors.Count());
                        var author = context.Authors.ToList()[authorIndex];
                        var edition = (EditionType)int.Parse(data[0]);
                        var releaseDate = DateTime.ParseExact(data[1], "d/M/yyyy", CultureInfo.InvariantCulture);
                        var copies = int.Parse(data[2]);
                        var price = decimal.Parse(data[3]);
                        var ageRestriction = (AgeRestriction)int.Parse(data[4]);
                        var title = data[5];

                        context.Books.Add(new Book()
                        {
                            Author = author,
                            EditionType = edition,
                            ReleaseDate = releaseDate,
                            Copies = copies,
                            Price = price,
                            AgeRestriction = ageRestriction,
                            Title = title
                        });

                        line = reader.ReadLine();
                    }

                }
            }

            context.SaveChanges();

            //Random random2 = new Random();
            //foreach (var book   in context.Books)
            //{
            //    var categoryIndex = random2.Next(1, context.Category.Count());

            //    book.Category = context.Category.Find(categoryIndex);
            //}

            context.SaveChanges();

        }
    }
}
