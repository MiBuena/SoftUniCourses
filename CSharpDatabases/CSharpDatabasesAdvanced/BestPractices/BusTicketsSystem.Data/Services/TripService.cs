using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Data.Services
{
    public class TripService
    {
        private readonly IUnitOfWork unit;

        public TripService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string ChangeTripStatus(int id, string status)
        {
            var trip = unit.Trips.GetById(id);

            string result =
                $"Trip from {trip.OriginBusStation.Town.Name} to {trip.DestinationBusStation.Town.Name} on {trip.DepartureTime} Status changed from {trip.Status} to {status}";

            trip.Status = (TripStatus)Enum.Parse(typeof(TripStatus), status);

            unit.Save();

            return result;
        }
    }
}
