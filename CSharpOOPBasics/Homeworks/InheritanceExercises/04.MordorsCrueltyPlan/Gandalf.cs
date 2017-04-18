using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan
{
    class Gandalf
    {
        public int TotalHappinessPoints { get; set; }
        public string Mood { get; set; }

        public void Eat(Food food)
        {
            this.TotalHappinessPoints += food.Points;
        }

        public void CalculateMood()
        {
            this.Mood = MoodFactory.ProduceMood(this.TotalHappinessPoints);
        }
    }
}
