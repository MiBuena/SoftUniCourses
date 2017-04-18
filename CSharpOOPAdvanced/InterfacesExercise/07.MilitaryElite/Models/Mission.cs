using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    class Mission : IMission
    {

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }
        public string State { get; set; }

        public void CompleteMission()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string printing = $"Code Name: {this.CodeName} State: {this.State}";
            return printing;
        }
    }
}
