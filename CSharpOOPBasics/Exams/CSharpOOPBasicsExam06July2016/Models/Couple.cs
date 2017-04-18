using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class Couple: BasicHousehold, ICouple
    {

        public Couple(int roomNumber, decimal roomConsumption, decimal tvConsumption, decimal fridgeConsumption, params IIncomePerson[] incomePersons) : base(roomNumber, roomConsumption, incomePersons)
        {
            this.TvConsumption = tvConsumption;
            this.FridgeConsumption = fridgeConsumption;
        }

        public override decimal HouseholdConsumption
        {
            get
            {
                decimal consumption = base.HouseholdConsumption + this.FridgeConsumption + this.TvConsumption;

                return consumption;
            }
        }

        public decimal TvConsumption { get; }
        public decimal FridgeConsumption { get; }


    }
}
