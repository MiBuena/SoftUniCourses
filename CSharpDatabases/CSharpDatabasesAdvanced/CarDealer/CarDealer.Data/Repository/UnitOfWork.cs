using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Data.Interfaces;
using CarDealer.Models;

namespace CarDealer.Data.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly CarDealerContext context;

        private IRepository<Car> cars;

        private IRepository<Customer> customers;

        private IRepository<Part> parts;

        private IRepository<PartSupplier> partsSupplier;

        private IRepository<Sale> sales;




        public UnitOfWork()
        {
            this.context = new CarDealerContext();
        }

        public IRepository<Car> Cars
        {
            get { return this.cars ?? (this.cars = new Repository<Car>(this.context)); }
        }

        public IRepository<Customer> Customers
        {
            get { return this.customers ?? (this.customers = new Repository<Customer>(this.context)); }
        }

        public IRepository<Part> Parts
        {
            get { return this.parts ?? (this.parts = new Repository<Part>(this.context)); }
        }

        public IRepository<PartSupplier> PartSupplier
        {
            get { return this.partsSupplier ?? (this.partsSupplier = new Repository<PartSupplier>(this.context)); }
        }

        public IRepository<Sale> Sales
        {
            get { return this.sales ?? (this.sales = new Repository<Sale>(this.context)); }
        }


        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
