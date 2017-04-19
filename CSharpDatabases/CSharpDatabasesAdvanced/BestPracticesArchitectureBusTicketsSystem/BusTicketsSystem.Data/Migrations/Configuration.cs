using BusTicketsSystem.Models;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BusTicketsSystem.Data.BusTicketsSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BusTicketsSystem.Data.BusTicketsSystemContext context)
        {
            if (!context.BankAccounts.Any())
            {
                context.BankAccounts.Add(new BankAccount()
                {
                    AccountNumber = "124234",
                    Balance = 5M,
                    Customer = new Customer()
                    {
                        DateOfBirth = DateTime.Now,
                        FirstName = "John",
                        LastName = "Best",
                        Gender = Gender.Male,
                        HomeTown = new Town()
                        {
                            Country = "Bulgaria",
                            Name = "Sofia"
                        }
                    }

                });

                context.BankAccounts.Add(new BankAccount()
                {
                    AccountNumber = "987985678",
                    Balance = 15M,
                    Customer = new Customer()
                    {
                        DateOfBirth = new DateTime(2010, 02, 01),
                        FirstName = "Baby",
                        LastName = "TheBest",
                        Gender = Gender.Female,
                        HomeTown = new Town()
                        {
                            Country = "Germany",
                            Name = "Berlin"
                        }
                    }

                });

                context.BankAccounts.Add(new BankAccount()
                {
                    AccountNumber = "87689",
                    Balance = 10M,
                    Customer = new Customer()
                    {
                        DateOfBirth = new DateTime(2016, 02, 01),
                        FirstName = "Michael",
                        LastName = "Donnovan",
                        Gender = Gender.Male,
                        HomeTown = new Town()
                        {
                            Country = "U.K.",
                            Name = "London"
                        }
                    }

                });
            }

            context.SaveChanges();


            if (!context.BusCompanies.Any())
                {
                    context.BusCompanies.Add(new BusCompany()
                    {
                        Name = "Union Ivkoni",
                        Nationality = "BG",
                        Rating = 10M
                    });

                    context.BusCompanies.Add(new BusCompany()
                    {
                        Name = "Varna trans",
                        Nationality = "BG",
                        Rating = 10M
                    });

                    context.BusCompanies.Add(new BusCompany()
                    {
                        Name = "London trans",
                        Nationality = "UK",
                        Rating = 10M
                    });
                }
            context.SaveChanges();


            if (!context.BusStations.Any())
                {
                    context.BusStations.Add(new BusStation()
                    {
                        Name = "First station",
                        Town = context.Towns.FirstOrDefault()
                    });

                    context.BusStations.Add(new BusStation()
                    {
                        Name = "Second station",
                        Town = context.Towns.FirstOrDefault(x=>x.Id==2)
                    });

                    context.BusStations.Add(new BusStation()
                    {
                        Name = "Third station",
                        Town = context.Towns.FirstOrDefault(x=>x.Id == 3)
                    });
                }

            context.SaveChanges();


            if (!context.Reviews.Any())
                {
                    context.Reviews.Add(new Review()
                    {
                        BusCompany = context.BusCompanies.FirstOrDefault(),
                        BusStation = context.BusStations.FirstOrDefault(),
                        Content = "It's great",
                        Customer = context.Customers.FirstOrDefault(),
                        DateAndTimeOfPublishing = new DateTime(2016, 05, 01),
                        Grade = 5.5M
                    });

                    context.Reviews.Add(new Review()
                    {
                        BusCompany = context.BusCompanies.FirstOrDefault(x=>x.Id == 2),
                        BusStation = context.BusStations.FirstOrDefault(x=>x.Id == 2),
                        Content = "It's bad",
                        Customer = context.Customers.FirstOrDefault(x=>x.Id ==2),
                        DateAndTimeOfPublishing = new DateTime(2016, 09, 05),
                        Grade = 9.5M
                    });


            }

            context.SaveChanges();

            if (!context.Tickets.Any())
                {
                    context.Tickets.Add(new Ticket()
                    {
                        Customer = context.Customers.FirstOrDefault(),
                        Price = 55M,
                        Seat = "80",
                        Trip = new Trip()
                        {
                            ArrivalTime = new DateTime(2016, 01, 02),
                            BusCompany = context.BusCompanies.FirstOrDefault(),
                            DepartureTime = new DateTime(2016, 01, 01),
                            DestinationBusStation = context.BusStations.FirstOrDefault(),
                            OriginBusStation = context.BusStations.FirstOrDefault(),
                            Status = TripStatus.Arrived
                        }
                    });

                    context.Tickets.Add(new Ticket()
                    {
                        Customer = context.Customers.FirstOrDefault(x=>x.Id == 2),
                        Price = 35M,
                        Seat = "20",
                        Trip = new Trip()
                        {
                            ArrivalTime = new DateTime(2015, 05, 05),
                            BusCompany = context.BusCompanies.FirstOrDefault(),
                            DepartureTime = new DateTime(2015, 05, 06),
                            DestinationBusStation = context.BusStations.FirstOrDefault(),
                            OriginBusStation = context.BusStations.FirstOrDefault(x=>x.Id == 2),
                            Status = TripStatus.Delayed
                        }
                    });

                    context.Tickets.Add(new Ticket()
                    {
                        Customer = context.Customers.FirstOrDefault(x=>x.Id == 3),
                        Price = 45M,
                        Seat = "50",
                        Trip = new Trip()
                        {
                            ArrivalTime = new DateTime(2015, 04, 05),
                            BusCompany = context.BusCompanies.FirstOrDefault(x=>x.Id == 3),
                            DepartureTime = new DateTime(2015, 04, 06),
                            DestinationBusStation = context.BusStations.FirstOrDefault(x=>x.Id == 3),
                            OriginBusStation = context.BusStations.FirstOrDefault(x=>x.Id == 3),
                            Status = TripStatus.Departed
                        }
                    });
                }

               

            context.SaveChanges();

        }
    }
}
