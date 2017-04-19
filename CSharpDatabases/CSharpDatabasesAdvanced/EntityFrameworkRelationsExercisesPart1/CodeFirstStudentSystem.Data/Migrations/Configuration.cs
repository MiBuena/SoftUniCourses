using System.Security.Cryptography.X509Certificates;
using CodeFirstStudentSystem.Models;

namespace CodeFirstStudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstStudentSystem.Data.StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CodeFirstStudentSystem.Data.StudentSystemContext context)
        {
            if (!context.Students.Any())
            {
                Student first = new Student()
                {
                    Birthday = new DateTime(1988, 06, 29),
                    Name = "Pesho",
                    RegistrationDate = DateTime.Now,
                    PhoneNumber = "0035903984"
                };

                Student second = new Student()
                {
                    Birthday = new DateTime(1990, 01, 01),
                    Name = "Gosho",
                    RegistrationDate = DateTime.Now,
                    PhoneNumber = "0035903984"
                };


                Student third = new Student()
                {
                    Birthday = new DateTime(1992, 01, 01),
                    Name = "Dancho",
                    RegistrationDate = DateTime.Now,
                    PhoneNumber = "0035903984"
                };

                context.Students.AddRange(new[] {first, second, third});
                context.SaveChanges();
            }

    //        context.Homeworks.AddOrUpdate(
    //            x => x.Content,
    //            new Homework()
    //            {
    //                Id = 1,
    //                Content = "Bullshit",
    //                ContentType = "PDF",
    //                Student = context.Students.FirstOrDefault(),
    //                SubmissionDate = DateTime.Now

    //            },
    //            new Homework()
    //            {
    //                Id = 2,
    //                Content = "Bullshit2",
    //                ContentType = "PDF2",
    //                Student = context.Students.FirstOrDefault(),
    //                SubmissionDate = DateTime.Now
    //            }
    //            );

    //        context.Resources.AddOrUpdate(
    //x => x.URL,
    //new Resource()
    //{
    //    Name = "ProfilePicture",
    //    TypeOfResource = "JPG",
    //    URL = "kjhkjhkj"
    //},
    //    new Resource()
    //    {
    //        Name = "ProfilePicture",
    //        TypeOfResource = "JPG",
    //        URL = "kkjhjhkjhkj"
    //    }
    //);

    //        context.SaveChanges();


            //context.Courses.AddOrUpdate(
            //    x => x.Name,

            //    new Course()
            //    {
            //        Description = "The best course",
            //        EndDate = DateTime.Now,
            //        Name = "OOP",
            //        StartDate = DateTime.Now,
            //        Price = 100M
            //    },

            //                    new Course()
            //                    {
            //                        Description = "The best course",
            //                        EndDate = DateTime.Now,
            //                        Name = "OOP2",
            //                        StartDate = DateTime.Now,
            //                        Price = 100M
            //                    }


            //    );

            //context.SaveChanges();


            //context.Courses.Find(1).HomeworkSubmissions.Add(context.Homeworks.FirstOrDefault());
            //context.Courses.Find(1).Students.Add(context.Students.Find(1));
            //context.Courses.Find(1).Resources.Add(context.Resources.FirstOrDefault());


            //context.Courses.Find(2).HomeworkSubmissions.Add(context.Homeworks.Find(2));
            //context.Courses.Find(2).Students.Add(context.Students.Find(1));
            //context.Courses.Find(2).Students.Add(context.Students.Find(2));
            //context.Courses.Find(2).Resources.Add(context.Resources.Find(1));
            //context.Courses.Find(2).Resources.Add(context.Resources.Find(2));

            //context.Students.Find(1).Courses.Add(context.Courses.Find(1));
            //context.Students.Find(1).Courses.Add(context.Courses.Find(2));
            //context.Students.Find(2).Courses.Add(context.Courses.Find(1));
            //context.Students.Find(2).Courses.Add(context.Courses.Find(2));

            //context.Students.Find(1).Homeworks.Add(context.Homeworks.Find(2));
            //context.Students.Find(1).Homeworks.Add(context.Homeworks.Find(1));


            //context.SaveChanges();

        }
    }
}
