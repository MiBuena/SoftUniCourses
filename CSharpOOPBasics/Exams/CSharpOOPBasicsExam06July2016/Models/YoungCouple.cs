using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class YoungCouple : Couple, IYoungHousehold
    {
        public const int YoungCoupleRoomConsumption = 20;
        public const int YoungCoupleRoomNumber = 2;
        public const int YoungCoupleNumberOfLaptops = 2;

        public YoungCouple(decimal tvConsumption, decimal fridgeConsumption, decimal laptionConsumption, params IIncomePerson[] incomePersons) : this(YoungCoupleRoomNumber, YoungCoupleRoomConsumption, tvConsumption, fridgeConsumption, laptionConsumption, incomePersons)
        {
        }

        public YoungCouple(int roomNumber, decimal roomConsumption, decimal tvConsumption, decimal fridgeConsumption, decimal laptionConsumption, params IIncomePerson[] incomePersons) : base(roomNumber, roomConsumption, tvConsumption, fridgeConsumption, incomePersons)
        {
            this.LaptopConsumption = laptionConsumption;
        }





        public decimal LaptopConsumption { get; }

        public override decimal HouseholdConsumption
        {
            get
            {
                decimal consumption = base.HouseholdConsumption + this.LaptopConsumption * YoungCoupleNumberOfLaptops;

                return consumption;
            }
        }



    }
}
