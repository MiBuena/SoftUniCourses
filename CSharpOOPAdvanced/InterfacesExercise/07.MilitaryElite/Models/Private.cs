using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            string printing = base.ToString() + " Salary: " + $"{this.Salary:F2}";

            return printing;
        }
    }
}
