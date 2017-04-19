using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballBettingDatabase.Data;

namespace FootballBettingDatabase.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballBettingContext context = new FootballBettingContext();

            context.Bets.FirstOrDefault();
        }
    }
}
