using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Animal
    {
        private Gender gender;

        public Kitten(string name, double age) : base(name, age, Gender.Female)
        {
        }

        public override Gender Gender
        {
            get { return this.gender; }
            set
            {
                if (value != Gender.Female)
                {
                    throw new ArgumentException();
                }

                this.gender = value;
            }
        }
    }
}
