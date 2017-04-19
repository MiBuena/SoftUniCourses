using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Data.Services;

namespace BusTicketsSystem.ConsoleClient.Core.Commands
{
    public class ChangeTripStatusCommand : Command
    {
        private TripService tripService;

        public ChangeTripStatusCommand(string[] data, IUnitOfWork unitOfWork) : base(data)
        {
            this.tripService = new TripService(unitOfWork);
        }

        public override string Execute()
        {
            string result = this.tripService.ChangeTripStatus(int.Parse(this.Data[1]), this.Data[2]);

            return result;
        }
    }
}
