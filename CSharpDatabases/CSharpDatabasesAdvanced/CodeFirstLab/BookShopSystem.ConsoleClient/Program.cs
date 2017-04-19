using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BookShopSystem.Data;
using BookShopSystem.Data.Migrations;
using EntityFramework.Extensions;
using Models;
using Models.Enumerations;

namespace BookShopSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            try
            {

                var context = new BookShopContext();

                //Task 1: Get all books after the year 2000. Print only their titles.

                //var booksTitles = context.Books.Where(x => x.ReleaseDate.Year > 2000).ToList();

                //Task 2: Get all authors with at least one book with release date before 1990. Print their first name and last name.

                //var authors = context.Authors.Where(x => x.Books.Any(y => y.ReleaseDate.Year < 1990)).Select(z =>
                //    new {FirstName = z.FirstName, LastName = z.LastName}).ToList();

                //Task 3: Get all authors, ordered by the number of their books (descending). Print their first name, last name and book count.	

                //var authors = context.Authors.OrderByDescending(x => x.Books.Count).Select(y => new { y.FirstName, y.LastName, y.Books.Count}).ToList();


                //Task 4: Get all books from author George Powell, ordered by their release date(descending), then by book title (ascending).Print the book's title, release date and copies.

                //var books =
                //    context.Books.Where(x => x.Author.FirstName == "George" && x.Author.LastName == "Powell")
                //        .OrderByDescending(y => y.ReleaseDate)
                //        .ThenBy(y => y.Title).Select(z => new {z.Title, z.ReleaseDate, z.Copies}).ToList();


                //Task 5 **Get the most recent books by categories. The categories should be ordered by total book count. Only take the top 3 most recent books from each category - ordered by date (descending), then by title (ascending). Select the category name, total book count and for each book - its title and release date.

                //var categories =
                //    context.Category.OrderByDescending(x => x.Books.Count)
                //        .Select(
                //            y =>
                //                new
                //                {
                //                    Name = y.Name,
                //                    BookCount = y.Books.Count,
                //                    Books =
                //                        y.Books.OrderByDescending(z => z.ReleaseDate)
                //                            .ThenBy(m => m.Title).Take(3)
                //                            .Select(book => new {Title = book.Title, ReleaseDate = book.ReleaseDate})
                //                });

                //foreach (var element in categories)
                //{
                //    Console.WriteLine($"--{element.Name} {element.BookCount} books");
                //    foreach (var element2 in element.Books)
                //    {
                //        Console.WriteLine($"{element2.Title} ({element2.ReleaseDate.Year})");
                //    }

                //    Console.WriteLine();
                //}

                //Lab Second Part
                //            var books = context.Books
                //.Take(3)
                //.ToList();
                //            //books[0].RelatedBooks.Add(books[1]);
                //            //books[1].RelatedBooks.Add(books[0]);
                //            //books[0].RelatedBooks.Add(books[2]);
                //            //books[2].RelatedBooks.Add(books[0]);

                //            context.SaveChanges();

                //            var booksFromQuery = books.Select(x => new {Title = x.Title, RelatedBooks = x.RelatedBooks});

                //            foreach (var book in booksFromQuery)
                //            {
                //                Console.WriteLine("--{0}", book.Title);
                //                foreach (var relatedBook in book.RelatedBooks)
                //                {
                //                    Console.WriteLine(relatedBook.Title);
                //                }
                //            }

                //Exercises: Advanced Querying
                //Task 1: Books Titles by Age Restriction
                //string ageRestrictionInput = Console.ReadLine().ToLower();

                //var booksTitles =
                //    context.Books.Where(x => x.AgeRestriction.ToString().ToLower() == ageRestrictionInput)
                //        .Select(y => y.Title);

                //foreach (var element in booksTitles)
                //{
                //    Console.WriteLine(element);
                //}

                //Task 2: Write a program that selects and prints titles of the golden edition books and have less than 5000 copies.

                //var books =
                //    context.Books.Where(x => x.EditionType == EditionType.Gold && x.Copies < 5000).Select(y => y.Title);

                //foreach (var book in books)
                //{
                //    Console.WriteLine(book);
                //}


                //Task 3 Write a program that selects prints titles and price of books with price lower than 5 and higher than 40.

                //var books = context.Books.Where(x => x.Price < 5 || x.Price > 40).Select(y => new {y.Title, y.Price});

                //foreach (var book in books)
                //{
                //    Console.WriteLine($"{book.Title} - ${book.Price}");
                //}

                //Task 4 Write a program that selects and prints titles of all books that are NOT released on given year.
                //int year = int.Parse(Console.ReadLine());

                //var books = context.Books.Where(x => x.ReleaseDate.Year != year).Select(y=>y.Title);


                //foreach (var book in books)
                //{
                //    Console.WriteLine($"{book}");
                //}

                //Task 5 Write a program that selects and print titles of books by given list of categories. The list of categories will be given in a single one separated with one or more spaces. NOTE: The results here may not be like the one above, because of the random attachment of an category to the book.

                //List<string> listCategories = Console.ReadLine().Split(' ').ToList();

                //foreach (var element in listCategories)
                //{
                //    var books = context.Books.Where(x => x.Category.Name == element).Select(y => y.Title);

                //    foreach (var element2 in books)
                //    {
                //        Console.WriteLine(element2);
                //    }
                //}


                //Task 6 Write a program that selects and prints title, edition type and price of books that are released before given date as an input from the console. The date will be in format dd-MM-yyyy.

                //string stringDatetime = Console.ReadLine();

                //DateTime date = DateTime.ParseExact(stringDatetime, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                //var books =
                //    context.Books.Where(x => x.ReleaseDate < date).Select(y => new {y.Title, y.EditionType, y.Price});

                //foreach (var element in books)
                //{
                //    Console.WriteLine($"{element.Title} - {element.EditionType} - {element.Price}");
                //}

                //Task 7 Write a program that selects and prints names of those authors whose first name end with given string

                //string input = Console.ReadLine();

                //var authors = context.Authors.Where(x => x.FirstName.Substring(x.FirstName.Length - input.Length, input.Length).ToString() == input).Select(y=>new { FirstName = y.FirstName, LastName = y.LastName});

                //foreach (var element in authors)
                //{
                //    Console.WriteLine($"{element.FirstName + " " + element.LastName}");
                //}

                //Task 8 Write a program that selects and prints titles of books which contains given string (regardless of the casing).

                //string input = Console.ReadLine().ToLower();

                //var books = context.Books.Where(x => x.Title.ToLower().Contains(input)).Select(y=>y.Title);

                //foreach (var element in books)
                //{
                //    Console.WriteLine(element);
                //}

                //Task 9 Write a program that selects and prints titles of books which are written by authors whose last name start with given string.
                //string input = Console.ReadLine().ToLower();

                //var titles =
                //    context.Books.Where(x => x.Author.LastName.Substring(0, input.Length) == input).Select(y => new {y.Title, y.Author.LastName});

                //foreach (var element in titles)
                //{
                //    Console.WriteLine(element);
                //}

                //Task 10 Write a program that selects and prints number of books whose title is longer than a number given as an input.
                //int number = int.Parse(Console.ReadLine());

                //var books = context.Books.Count(x => x.Title.Length > number);

                //Console.WriteLine(books);

                //Task 11 

                //var books = context.Books.GroupBy(x => x.Author).Select(y => new { Sum = y.Key.Books.Sum(g => g.Copies), FirstName = y.Key.FirstName, LastName = y.Key.LastName }).OrderByDescending(z => z.Sum);

                //foreach (var element in books)
                //{
                //    Console.WriteLine(element.FirstName + " " + element.LastName + " " + element.Sum);
                //}

                //Task 12 Write a program that selects and print the total profit of all books by category. Profit for a book can be calculated by multiplying its number of copies with price per single book. Order the results descending by total profit for category and ascending by category name.

                //var books =
                //    context.Books.GroupBy(x => x.Category)
                //        .Select(y => new { CategoryName = y.Key.Name, Profit = y.Key.Books.Sum(z => z.Price * z.Copies) }).OrderByDescending(x => x.Profit).ThenBy(y => y.CategoryName);

                //foreach (var element in books)
                //{
                //    Console.WriteLine(element.CategoryName + " - $" + element.Profit);
                //}

                //Task 13 Get the most recent books by categories. The categories should be ordered by total book count. Only take the top 3 most recent books from each category - ordered by date (descending), then by title (ascending). Select and print the category name, total book count and for each book - its title and release date. Get only those categories that have total book count more than 35.

                //var books =
                //    context.Category.Where(n=>n.Books.Count>35).OrderByDescending(x => x.Books.Count)
                //        .Select(y => new
                //        {
                //            Name = y.Name, BookCount = y.Books.Count, Books = y.Books.OrderByDescending(z=>z.ReleaseDate).ThenBy(z=>z.Title).Take(3).Select(m=>new { m.Title, m.ReleaseDate})});

                //foreach (var element in books)
                //{
                //    Console.WriteLine($"--{element.Name}: {element.BookCount} books");

                //    foreach (var element2 in element.Books)
                //    {
                //        Console.WriteLine($"{element2.Title} ({element2.ReleaseDate.Year})");
                //    }
                //}

                //Task 14 Write a program that increases the copies of all books released after given date with given number. Print the total amount of book copies that were added.

                //string date = Console.ReadLine();

                //DateTime releaseDate = DateTime.ParseExact(date, "dd MMM yyyy", CultureInfo.InvariantCulture);

                //int number = int.Parse(Console.ReadLine());

                //int totalNumber = 0;

                //int count = context.Books.Count(y => y.ReleaseDate > releaseDate);


                //context.Books.Where(x => x.ReleaseDate > releaseDate)
                //    .Update(book => new Book() {Copies = book.Copies + number});


                //Console.WriteLine(count*number);


                //Task 15 Write a program that removes from the database those books whose copies are lower than given number. Print on the console the number of books that were deleted from the database.

                //int number = int.Parse(Console.ReadLine());

                //int numberOfRemovedBooks = context.Books.Where(x => x.Copies < number).Count();

                //context.Books.Delete(x => x.Copies < number);

                //Console.WriteLine(numberOfRemovedBooks);

                //Task 16 Using SQL Server Management Studio create stored procedure that receives authors first and last name and returns the total number of books that author has written. Then write a program that receives author name from the console and prints the total number of books that author has written by using the stored procedure you’ve just created.

                //string[] name = Console.ReadLine().Split(' ');


                //SqlParameter param = new SqlParameter("@param", SqlDbType.NVarChar);

                //SqlParameter param2 = new SqlParameter("@param2", SqlDbType.NVarChar);


                //param.Value = name[0];

                //param2.Value = name[1];


                //int count = context.Database.SqlQuery<int>("udp_CheckNumberOfBooks @param, @param2", param, param2).Single();

                //Console.WriteLine(count);

            }
            catch (DbEntityValidationException ex)
            {
                //TransformTag();

                foreach (DbEntityValidationResult dbEntityValidationResult in ex.EntityValidationErrors)
                {
                    foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        Console.WriteLine($"{dbValidationError.PropertyName} {dbValidationError.ErrorMessage}");
                    }
                }
            }
        }
    }
}
