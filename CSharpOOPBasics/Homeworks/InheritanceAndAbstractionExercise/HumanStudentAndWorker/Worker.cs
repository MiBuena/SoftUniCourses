using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        private decimal moneyPerHour;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerH
        {
            get { return this.MoneyPerHour(); }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("workingHoursePerDay", "The working hours per day can not be negative");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("weekSalary", "The week salary can not be negative");
                }

                this.weekSalary = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary/5/WorkHoursPerDay;
        }

    }
}
