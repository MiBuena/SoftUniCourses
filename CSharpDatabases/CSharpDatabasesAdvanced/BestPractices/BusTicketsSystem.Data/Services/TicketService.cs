using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Data.Services
{
    public class TicketService
    {
        private readonly IUnitOfWork unit;

        public TicketService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string BuyTicket(string[] data)
        {
            int customerId = int.Parse(data[1]);

            int tripId = int.Parse(data[2]);

            decimal price = decimal.Parse(data[3]);

            string seat = data[4];


            Customer customer = unit.Customers.GetById(customerId);

            Trip trip = unit.Trips.GetById(tripId);

            if (customer.BankAccount.Balance< price)
            {
                throw new ArgumentNullException(nameof(price), "The customer does not have enough money for this ticket!");
            }

            customer.BankAccount.Balance -= price;

            Ticket ticket = new Ticket()
            {
                Customer = customer,
                Price = price,
                Seat = seat,
                Trip = trip
            };

            unit.Tickets.Add(ticket);

            unit.Save();

            string result =
                $"Customer {customer.FirstName + " " + customer.LastName} bought ticket for trip {tripId} for {price} on seat {seat}";

            return result;
        }

    }
}
