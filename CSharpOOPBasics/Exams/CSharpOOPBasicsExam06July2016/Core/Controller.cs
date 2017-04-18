using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;
using _01.KermenExam.Models;

namespace _01.KermenExam.Core
{
    public class Controller : IController
    {
        public Controller(IDatabase database)
        {
            this.Database = database;
        }

        public void PaySalaries()
        {
            foreach (var household in this.Database.Households)
            {
                household.GetSalaries();
            }
        }

        public string Democracy()
        {
            string message = $"Total population: {this.Database.Households.Sum(x => x.TotalPopulation)}";

            return message;
        }


        public string EVN()
        {
            string message = $"Total consumption: {this.Database.Households.Sum(x => x.HouseholdConsumption)}";

            return message;
        }

        public void EVNBill()
        {
            for (int i = 0; i < this.Database.Households.Count; i++)
            {
                var household = this.Database.Households[i];

                bool isAbleToPay = household.CheckIfBillsCanBePaid();

                if (isAbleToPay)
                {
                    household.PayBill();
                }
                else
                {
                    this.Database.Households.Remove(household);
                    i--;
                }
            }
        }

        public void CreateYoungCoupleWithChildrenHousehold(string parameters)
        {
            string incomePattern = @"^\w+\((\d+\.?\d+?)\,\s(\d+\.?\d+?)\)";
            
            var firstPerson = this.GetFirstPerson(parameters, incomePattern);

            var secondPerson = this.GetSecondPerson(parameters, incomePattern);

            string expensesPattern = @"\((\d+\.?(\d+)?)\)";

            var tvConsumption = this.GetTvCost(parameters, expensesPattern);

            var fridgeConsumption = this.GetFridgeCost(parameters, expensesPattern);

            var laptopCost = this.GetLaptopCost(parameters, expensesPattern);

            string childrenRegex = @"Child\((\d+(\,?\s+\d+)+)\)";


            var children = GetChildren(parameters, childrenRegex);

            YoungCoupleWithChildren youngCoupleWithChildren = new YoungCoupleWithChildren(tvConsumption, fridgeConsumption, laptopCost, children, firstPerson, secondPerson);

            Database.Households.Add(youngCoupleWithChildren);
        }

        private static ICollection<Child> GetChildren(string parameters, string childrenRegex)
        {
            ICollection<Child> children = new List<Child>();


            foreach (Match child in Regex.Matches(parameters, childrenRegex))
            {
                string[] numbers =
                    child.Groups[1].ToString().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();


                var foodCost = decimal.Parse(numbers[0]);

                ICollection<decimal> toyCosts = new List<decimal>();

                for (int i = 1; i < numbers.Length; i++)
                {
                    decimal toyCost = decimal.Parse(numbers[i]);

                    toyCosts.Add(toyCost);
                }


                Child newChild = new Child(foodCost, toyCosts);

                children.Add(newChild);
            }
            return children;
        }


        public void CreateAloneOldHousehold(string parameters)
        {
            string pattern = @"(?<=\()(\d+\.?(\d+)?)(?=\))";

            var incomeString = Regex.Matches(parameters, pattern)[0].Value;

            decimal income = decimal.Parse(incomeString);

            IIncomePerson person = new IncomePerson(income);

            this.Database.Households.Add(new AloneOld(person));
        }

        public void CreateOldCoupleHousehold(string parameters)
        {
            string incomePattern = @"^\w+\((\d+\.?\d+?)\,\s(\d+\.?\d+?)\)";

            var firstPensioner = this.GetFirstPerson(parameters, incomePattern);

            var secondPensioner = this.GetSecondPerson(parameters, incomePattern);


            string expensesPattern = @"\((\d+\.?(\d+)?)\)";

            var tvConsumption = this.GetTvCost(parameters, expensesPattern);

            var fridgeConsumption = this.GetFridgeCost(parameters, expensesPattern);

            var stoveConsumption = this.GetStoveCost(parameters, expensesPattern);

            this.Database.Households.Add(new OldCouple(tvConsumption, fridgeConsumption, stoveConsumption, firstPensioner, secondPensioner));
        }

        public void CreateAloneYoungHousehold(string parameters)
        {
            string pattern = @"\((\d+\.?(\d+)?)\)";

            var incomeString = Regex.Matches(parameters, pattern)[0].Groups[1].Value;

            decimal aloneYoungIncome = decimal.Parse(incomeString);


            var laptopElectricityCostString = Regex.Matches(parameters, pattern)[1].Groups[1].Value;

            decimal laptopConsumption = decimal.Parse(laptopElectricityCostString);

            IIncomePerson person = new IncomePerson(aloneYoungIncome);

            AloneYoung aloneYoung = new AloneYoung(laptopConsumption, person);

            this.Database.Households.Add(aloneYoung);
        }

        public void CreateYoungCoupleHousehold(string parameters)
        {
            string incomePattern = @"^\w+\((\d+\.?\d+?)\,\s(\d+\.?\d+?)\)";


            var firstPerson = this.GetFirstPerson(parameters, incomePattern);

            var secondPerson = this.GetSecondPerson(parameters, incomePattern);

            string expensesPattern = @"\((\d+\.?(\d+)?)\)";

            var tvConsumption = this.GetTvCost(parameters, expensesPattern);

            var fridgeConsumption = this.GetFridgeCost(parameters, expensesPattern);

            var laptopConsumption = this.GetLaptopCost(parameters, expensesPattern);

            YoungCouple youngCouple = new YoungCouple(tvConsumption, fridgeConsumption, laptopConsumption, firstPerson, secondPerson);

            this.Database.Households.Add(youngCouple);
        }

        private decimal GetLaptopCost(string parameters, string expensesPattern)
        {
            var laptopCostAsString = Regex.Matches(parameters, expensesPattern)[2].Groups[1].Value;

            decimal laptopCost = decimal.Parse(laptopCostAsString);
            return laptopCost;
        }


        private decimal GetStoveCost(string parameters, string expensesPattern)
        {
            var stoveCostAsString = Regex.Matches(parameters, expensesPattern)[2].Groups[1].Value;

            decimal stoveCost = decimal.Parse(stoveCostAsString);
            return stoveCost;
        }

        private decimal GetFridgeCost(string parameters, string expensesPattern)
        {
            var fridgeCostAsString = Regex.Matches(parameters, expensesPattern)[1].Groups[1].Value;

            decimal fridgeCost = decimal.Parse(fridgeCostAsString);
            return fridgeCost;
        }

        private decimal GetTvCost(string parameters, string expensesPattern)
        {
            var tvCostAsString = Regex.Matches(parameters, expensesPattern)[0].Groups[1].Value;

            decimal tvCost = decimal.Parse(tvCostAsString);
            return tvCost;
        }

        private IIncomePerson GetSecondPerson(string parameters, string pattern)
        {
            var secondPersonIncomeString = Regex.Matches(parameters, pattern)[0].Groups[2].Value;

            decimal secondPersonIncome = decimal.Parse(secondPersonIncomeString);


            IIncomePerson secondPerson = new IncomePerson(secondPersonIncome);
            return secondPerson;
        }

        private IIncomePerson GetFirstPerson(string parameters, string pattern)
        {
            var firstPersonIncomeString = Regex.Matches(parameters, pattern)[0].Groups[1].Value;

            decimal firstPersonIncome = decimal.Parse(firstPersonIncomeString);

            IIncomePerson firstPerson = new IncomePerson(firstPersonIncome);

            return firstPerson;
        }

        public IDatabase Database { get; private set; }
    }
}
