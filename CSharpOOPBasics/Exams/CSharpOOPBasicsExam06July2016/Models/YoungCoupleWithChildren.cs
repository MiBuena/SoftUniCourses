using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class YoungCoupleWithChildren : YoungCouple
    {
        public const int YoungCoupleWithChildrenRoomConsumption = 30;
        public const int YoungCoupleWithChildrenRoomNumber = 2;
        public const int YoungCoupleWithChildrenNumberOfLaptops = 2;



        public YoungCoupleWithChildren(decimal tvConsumption, decimal fridgeConsumption, decimal laptionConsumption, ICollection<Child> children, params IIncomePerson[] incomePersons) : base(YoungCoupleWithChildrenRoomNumber, YoungCoupleWithChildrenRoomConsumption, tvConsumption, fridgeConsumption, laptionConsumption, incomePersons)
        {
            this.Children = children;
        }



        public ICollection<Child> Children { get; }

        public override decimal HouseholdConsumption
        {
            get
            {
                decimal consumption = this.RoomNumber*this.RoomConsumption + this.FridgeConsumption + this.TvConsumption +
                                      this.LaptopConsumption*YoungCoupleWithChildrenNumberOfLaptops;

                consumption += this.Children.Sum(x => x.TotalCost);

                return consumption;
            }
        }

        public override int TotalPopulation
        {
            get
            {
                int people = base.TotalPopulation;
                people += this.Children.Count;

                return people;
            }
        }



    }
}
