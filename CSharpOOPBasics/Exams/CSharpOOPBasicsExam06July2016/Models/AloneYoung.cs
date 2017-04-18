using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class AloneYoung : BasicHousehold, IYoungHousehold
    {
        private const decimal AloneYoungRoomConsumption = 10;
        private  const int AloneYoungRoomNumber = 1;
        private const int AloneYoungNumberOfLaptops = 1;

        public AloneYoung(decimal laptopConsumption, params IIncomePerson[] incomePersons) : base(AloneYoungRoomNumber, AloneYoungRoomConsumption, incomePersons)
        {
            this.LaptopConsumption = laptopConsumption;
        }



        public override decimal HouseholdConsumption
        {
            get
            {
                decimal consumption = base.HouseholdConsumption + this.LaptopConsumption*AloneYoungNumberOfLaptops;

                return consumption;
            }
        }

        public decimal LaptopConsumption { get; }


    }
}
