using System.Collections.Generic;
using _01.KermenExam.Models;

namespace _01.KermenExam.Interfaces
{
    public interface IHousehold
    {
        decimal Income { get; }

        int RoomNumber { get; }

        decimal RoomConsumption { get; }

        decimal HouseholdBudget { get; }

        decimal HouseholdConsumption { get; }

        int TotalPopulation { get;}

        ICollection<IIncomePerson> PeopleWithIncome { get; }

        void GetSalaries();

        bool CheckIfBillsCanBePaid();

        void PayBill();
    }
}
