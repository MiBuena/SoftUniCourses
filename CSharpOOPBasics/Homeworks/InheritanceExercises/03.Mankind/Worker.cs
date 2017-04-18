using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
    class Worker:Human
    {
        private string lastName;
        private decimal weekSalary;
        private int workingHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.LastName = lastName;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workingHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHoursPerDay = value;
            }
        }

        public decimal CalculateMoneyPerHour()
        {
            decimal moneyPerHour = (this.WeekSalary / 5) / this.WorkHoursPerDay;

            return moneyPerHour;
        }

        public override string LastName
        {
            get { return base.LastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                base.LastName = value;
            }
        }

        public override string ToString()
        {
            string worker = base.ToString();

            worker +=
                String.Format(
                    $"\nWeek Salary: {this.WeekSalary:F2}\nHours per day: {this.WorkHoursPerDay:f2}\nSalary per hour: {this.CalculateMoneyPerHour():F2}");
            return worker;
        }
    }
}
