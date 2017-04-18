using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class Soldier : ISoldier
    {

        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            string printing = $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";

            return printing;
        }
    }
}
