using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, string codeNumber) : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public string CodeNumber { get; set; }

        public override string ToString()
        {
            string printing = base.ToString() + $"\nCode Number: {this.CodeNumber}";

            return printing;
        }
    }
}
