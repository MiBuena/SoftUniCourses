using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Data.Services;

namespace BusTicketsSystem.ConsoleClient.Core.Commands
{
    class PrintInfoCommand : Command
    {
        private BusStationService busStationService;

        public PrintInfoCommand(string[] data, IUnitOfWork unitOfWQork) : base(data)
        {
            this.busStationService = new BusStationService(unitOfWQork);
        }

        public override string Execute()
        {
            var trips = this.busStationService.GetTrips(int.Parse(this.Data[1]));

            var busStation = this.busStationService.GetBusStation(int.Parse(this.Data[1]));


            string result = "" + busStation.Name + ", " + busStation.Town.Name + "\n";

            result += "Arrivals:\n";

            foreach (var element in trips.LastOrDefault())
            {

                result +=
                    $"From {element.OriginBusStation.Name} | Arrive at: {element.ArrivalTime} | Status: {element.Status}\n";
            }

            result += "Departures:\n";


            foreach (var element in trips.FirstOrDefault())
            {
                result +=
                    $"To {element.DestinationBusStation.Name} | Depart at: {element.DepartureTime} | Status: {element.Status}\n";
            }

            return result;
        }
    }
}
