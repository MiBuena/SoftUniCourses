using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Data.Repositories;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Data.Services
{
    public class BusStationService
    {
        private readonly IUnitOfWork unit;

        public BusStationService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public BusStation GetBusStation(int id)
        {
            var busStation = unit.BusStations.GetById(id);

            return busStation;
        }


        public IEnumerable<IEnumerable<Trip>> GetTrips(int busStationId)
        {
            if (busStationId == 0)
            {
                throw new ArgumentNullException(nameof(busStationId), "Id should not be 0!");
            }

            var result = new List<List<Trip>>();

            List<Trip> departuresCollection = this.unit.BusStations.Find(x => x.Id == busStationId).FirstOrDefault().OriginTrips.ToList();

            List<Trip> arrivalsCollection = this.unit.BusStations.Find(x => x.Id == busStationId).FirstOrDefault().DestinationTrips.ToList();

            result.Add(departuresCollection);

            result.Add(arrivalsCollection);

            return result;
        }
    }
}
