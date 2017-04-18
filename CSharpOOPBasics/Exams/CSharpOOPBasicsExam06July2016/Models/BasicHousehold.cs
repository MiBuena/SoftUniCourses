using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public abstract class BasicHousehold : IHousehold
    {

        protected BasicHousehold(int roomNumber, decimal roomConsumption, params IIncomePerson [] incomePersons)
        {
            this.RoomNumber = roomNumber;
            this.RoomConsumption = roomConsumption;
            this.PeopleWithIncome = incomePersons;
        }


        public int RoomNumber { get; }

        public decimal RoomConsumption { get; }

        public decimal HouseholdBudget { get; private set; }


        public decimal Income
        {
            get
            {
                return this.PeopleWithIncome.Sum(x => x.Income);
            }
        }


        public virtual decimal HouseholdConsumption
        {
            get { return RoomConsumption*RoomNumber; }
        }

        public virtual int TotalPopulation
        {
            get
            {
                return this.PeopleWithIncome.Count;
            }
        }



        public ICollection<IIncomePerson> PeopleWithIncome { get; }



        public void GetSalaries()
        {
            this.HouseholdBudget += this.Income;
        }


        public bool CheckIfBillsCanBePaid()
        {
            if (this.HouseholdBudget < this.HouseholdConsumption)
            {
                return false;
            }

            return true;
        }

        public void PayBill()
        {
            this.HouseholdBudget -= this.HouseholdConsumption;
        }
    }
}
