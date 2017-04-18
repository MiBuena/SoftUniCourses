using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan
{
    class MoodFactory
    {
        public static string ProduceMood(int points)
        {
            string mood = null;

            if (points < -5)
            {
                mood = "Angry";
            }
            else if (points >= -5 && points <= 0)
            {
                mood = "Sad";
            }
            else if (points > 0 && points <= 15)
            {
                mood = "Happy";
            }
            else if (points > 15)
            {
                mood = "JavaScript";
            }

            return mood;
        }
    }
}
