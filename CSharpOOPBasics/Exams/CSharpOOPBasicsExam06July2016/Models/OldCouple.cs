using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class OldCouple : Couple
    {
        public const int OldCoupleRoomConsumption = 15;
        public const int OldCoupleRoomNumber = 3;


        public OldCouple(decimal tvConsumption, decimal fridgeConsumption, decimal stoveConsumption, params IIncomePerson[] incomePersons) : base(OldCoupleRoomNumber, OldCoupleRoomConsumption, tvConsumption, fridgeConsumption, incomePersons)
        {
            this.StoveConsumption = stoveConsumption;
        }

        public decimal StoveConsumption { get; }

        public override decimal HouseholdConsumption
        {
            get
            {
                decimal consumption = base.HouseholdConsumption + this.StoveConsumption;

                return consumption;
            }
        }



    }
}
