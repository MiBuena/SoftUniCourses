using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.CreateUser.Models;

namespace _02.CreateUser
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Task 1
                UserContext a = new UserContext();

                //byte[] b = File.ReadAllBytes("C:\\Users\\ff\\Pictures\\flower-25.jpg");
                //User user = new User("sdf7UJ!", "athina@gmail.com", "mibuena", new byte[0], DateTime.Now, DateTime.Now, 5, true, DateTime.Now);

                //User user2 = new User("askdjh345kjsOIUKJ!", "athina@gmail.com", "mibuena", b, DateTime.Now, DateTime.Now, 5, true, DateTime.Now);

                //a.Users.Add(user2);
                //a.Users.Add(user);
                //a.SaveChanges();

                //Task 2
                //string emailProvider = Console.ReadLine();

                //var users = a.Users.Where(x => x.Email.Contains("@" + emailProvider));

                //if (!users.Any())
                //{
                //    Console.WriteLine($"No users found with email domain {emailProvider}");
                //}
                //else
                //{
                //    foreach (var element in users)
                //    {
                //        Console.WriteLine($"{element.Username} {element.Email}");
                //    }
                //}

                //Task 3
                //int width = int.Parse(Console.ReadLine());

                //int counter = 0;

                //foreach (var element in a.Users)
                //{
                //    if (element.ProfilePicture != null)
                //    {
                //        using (var stream = new MemoryStream(element.ProfilePicture))
                //        {
                //            var image = System.Drawing.Image.FromStream(stream);

                //            if (image.Width > width)
                //            {
                //               counter++;
                //            }
                //        }
                //    }
                //}

                //Console.WriteLine($"{counter} users have profile pictures wider than 120 pixels");


                //Task 4
                //byte[] b = File.ReadAllBytes("C:\\Users\\ff\\Pictures\\flower-25.jpg");
                //User user = new User("sdfaaaaaa7UJ!", "athina@gmail.com", "mibuena", b, DateTime.Now, new DateTime(2015, 01, 01), 5, false, DateTime.Now);

                //User user2 = new User("sdfaaabbbbbbbbaaa7UJ!", "athina@gmail.com", "mibuena", new byte[0], DateTime.Now, new DateTime(2014, 01, 01), 5, false, DateTime.Now);

                //a.Users.Add(user2);
                //a.Users.Add(user);
                //a.SaveChanges();

                //string lastLoggedInDate = Console.ReadLine();

                //DateTime lastLoggedInDateTime = Convert.ToDateTime(lastLoggedInDate);


                //int counter = 0;

                //foreach (var element in a.Users)
                //{
                //    if (element.LastTimeLoggedIn < lastLoggedInDateTime)
                //    {
                //        element.IsDeleted = true;
                //        counter++;
                //    }
                //}

                //foreach (var element in a.Users)
                //{
                //    if (element.IsDeleted)
                //    {
                //        a.Users.Remove(element);
                //    }
                //}

                //a.SaveChanges();

                //Console.WriteLine($"{counter} users have been deleted");

                //Tag tag = new Tag()
                //{
                //    Name = "asdsrdd"
                //};

                
                //a.Tags.Add(tag);

                //Album firstAlbum = new Album();
                //firstAlbum.Tags.Add(a.Tags.FirstOrDefault());

                //a.Albums.Add(firstAlbum);




                //a.SaveChanges();


                Tag tag = new Tag()
                {
                    Name = "asdasd"
                };

                a.Tags.Add(tag);

                a.SaveChanges();
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
