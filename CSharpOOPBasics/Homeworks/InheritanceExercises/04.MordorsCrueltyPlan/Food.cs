using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan
{
    class Food
    {
        public Food(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; set; }
        public int Points { get; set; }
    }
}
