using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Data.Services;

namespace BusTicketsSystem.ConsoleClient.Core.Commands
{
    public class BuyTicketCommand : Command
    {
        private TicketService ticketService;

        public BuyTicketCommand(string[] data, IUnitOfWork unitOfWork) : base(data)
        {
            this.ticketService = new TicketService(unitOfWork);
        }

        public override string Execute()
        {
            return this.ticketService.BuyTicket(this.Data);
        }
    }
}
