using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GringottsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            //Task 1
            var deposit = new WizardDeposit()
            {
                FirstName = "Albus",
                LastName = "Dumbledore",
                Age = 150,
                MagicWandCreator = "Antioch Paverell",
                MagicWandSize = 15,
                DepositStartDate = new DateTime(2016, 10, 20),
                DepositExpirationDate = new DateTime(2020, 10, 20),
                DepositAmount = 20000.24m,
                DepositCharge = 0.2m,
                IsDepositExpired = false,

            };

            context.WizzarDeposits.Add(deposit);

            context.SaveChanges();
        }
    }
}
