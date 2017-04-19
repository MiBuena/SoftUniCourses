using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly BusTicketsSystemContext context;

        private IRepository<BankAccount> bankAccounts;
        private IRepository<BusCompany> busCompanies;
        private IRepository<BusStation> busStations;
        private IRepository<Customer> customers;
        private IRepository<Review> reviews;
        private IRepository<Ticket> tickets;
        private IRepository<Town> towns;
        private IRepository<Trip> trips;


        public UnitOfWork()
        {
            this.context = new BusTicketsSystemContext();
        }

        public IRepository<BankAccount> BankAccounts
        {
            get { return bankAccounts ?? (this.bankAccounts = new Repository<BankAccount>(this.context)); }
        }

        public IRepository<BusCompany> BusCompanies
        {
            get { return busCompanies ?? (this.busCompanies = new Repository<BusCompany>(this.context)); }
        }

        public IRepository<BusStation> BusStations
        {
            get { return busStations ?? (this.busStations = new Repository<BusStation>(this.context)); }
        }

        public IRepository<Customer> Customers
        {
            get { return customers ?? (this.customers = new Repository<Customer>(this.context)); }
        }
        public IRepository<Review> Reviews
        {
            get { return reviews ?? (this.reviews = new Repository<Review>(this.context)); }
        }
        public IRepository<Ticket> Tickets
        {
            get { return tickets ?? (this.tickets = new Repository<Ticket>(this.context)); }
        }

        public IRepository<Town> Towns
        {
            get { return towns ?? (this.towns = new Repository<Town>(this.context)); }
        }
        public IRepository<Trip> Trips
        {
            get { return trips ?? (this.trips = new Repository<Trip>(this.context)); }
        }


        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
