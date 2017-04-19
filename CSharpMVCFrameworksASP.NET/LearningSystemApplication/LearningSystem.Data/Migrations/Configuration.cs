using System.Web;
using LearningSystem.Models.EntityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LearningSystem.Data.LearningSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LearningSystem.Data.LearningSystemContext context)
        {
            AddRoles(context);

            AddUsers(context);

            AddCourses(context);
        }

        private static void AddUsers(LearningSystemContext context)
        {
            if (!context.Users.Any())
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);


                CreateUser(context, manager, "FirstUser", "aa@abv.bg", "Aa!1234", "Administrator", "Trainer", "Matthew");

                CreateUser(context, manager, "SecondUser", "aaa@abv.bg", "Aa!1234", "Trainer", null, "TheBest");

                CreateUser(context, manager, "ThirdUser", "aaaa@abv.bg", "Aa!1234", "BlogAuthor", null, "Mario");
            }
        }

        private static void CreateUser(LearningSystemContext context, UserManager<ApplicationUser> manager, string username, string email, string password, string secondRole, string thirdRole, string name)
        {
            var user = new ApplicationUser {UserName = username, Email = email};

            manager.Create(user, password);
            manager.AddToRole(user.Id, "Student");

            if (secondRole != null)
            {
                manager.AddToRole(user.Id, secondRole);
            }

            if (thirdRole != null)
            {
                manager.AddToRole(user.Id, thirdRole);
            }


            Student student = new Student()
            {
                BirthDate = new DateTime(1995, 07, 15),
                Name = name,
                UserId = user.Id
            };

            context.Students.Add(student);


            context.SaveChanges();
        }

        private static void AddCourses(LearningSystemContext context)
        {
            if (!context.Courses.Any())
            {


                context.Courses.AddOrUpdate(course => course.Name, new Course[]
                {
                    new Course()
                    {
                        Name = "Programing Basics - March 2016",
                        Description = "This course gives you basic knowledge of C# programming language.",
                        StartDate = new DateTime(2016, 03, 23),
                        EndDate = new DateTime(2016, 04, 30),
                        Trainer = context.Students.Find(1).User
                    },
                    new Course()
                    {
                        Name = "C# Advanced",
                        Description = "This is a course in Advanced C#",
                        StartDate = new DateTime(2017, 03, 23),
                        EndDate = new DateTime(2017, 04, 30),
                        Trainer = context.Students.Find(2).User
                    },
                    new Course()
                    {
                        Name = "C# OOP Basics",
                        Description =
                            "This course will teach you to the basic principles of Object-Oriented Programming.",
                        StartDate = new DateTime(2016, 03, 23),
                        EndDate = new DateTime(2016, 04, 30),
                        Trainer = context.Students.Find(1).User
                    },
                    new Course()
                    {
                        Name = "C# OOP Advanced",
                        Description = "In this course you will get to know the principles of High Quality Code",
                        StartDate = new DateTime(2017, 03, 23),
                        EndDate = new DateTime(2017, 04, 30),
                        Trainer = context.Students.Find(2).User
                    }
                });
            }


            context.SaveChanges();
        }

        private static void AddRoles(LearningSystemContext context)
        {
            if (!context.Roles.Any(x => x.Name == "Student"))
            {
                var roleManager = new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

                roleManager.Create(new IdentityRole("Student"));
            }

            if (!context.Roles.Any(x => x.Name == "Trainer"))
            {
                var roleManager = new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

                roleManager.Create(new IdentityRole("Trainer"));
            }

            if (!context.Roles.Any(x => x.Name == "BlogAuthor"))
            {
                var roleManager = new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

                roleManager.Create(new IdentityRole("BlogAuthor"));
            }


            if (!context.Roles.Any(x => x.Name == "Administrator"))
            {
                var roleManager = new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

                roleManager.Create(new IdentityRole("Administrator"));
            }

        }
    }
}
