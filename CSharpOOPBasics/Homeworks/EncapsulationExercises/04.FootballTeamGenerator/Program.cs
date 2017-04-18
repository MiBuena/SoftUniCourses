using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<FootballTeam> footballTeamsCollection = new List<FootballTeam>();

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    List<string> inputParameters =
                        input.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (inputParameters[0] == "Team")
                    {
                        FootballTeam newFootballTeam = new FootballTeam(inputParameters[1]);

                        footballTeamsCollection.Add(newFootballTeam);
                    }
                    else if (inputParameters[0] == "Add")
                    {
                        string teamName = inputParameters[1];
                        string newPlayerName = inputParameters[2];
                        decimal endurance = decimal.Parse(inputParameters[3]);
                        decimal sprint = decimal.Parse(inputParameters[4]);
                        decimal dribble = decimal.Parse(inputParameters[5]);
                        decimal passing = decimal.Parse(inputParameters[6]);
                        decimal shooting = decimal.Parse(inputParameters[7]);

                        FootballTeam teamToUpdate = footballTeamsCollection.FirstOrDefault(x => x.Name == teamName);

                        if (teamToUpdate == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                        Player newPlayer = new Player(newPlayerName, endurance, sprint, dribble, passing, shooting);

                        teamToUpdate.AddPlayer(newPlayer);
                    }
                    else if (inputParameters[0] == "Remove")
                    {
                        string teamName = inputParameters[1];
                        string newPlayerName = inputParameters[2];

                        FootballTeam teamToUpdate = footballTeamsCollection.FirstOrDefault(x => x.Name == teamName);

                        if (teamToUpdate == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                        teamToUpdate.RemovePlayer(newPlayerName);
                    }
                    else if (inputParameters[0] == "Rating")
                    {
                        string teamName = inputParameters[1];

                        FootballTeam team = footballTeamsCollection.FirstOrDefault(x => x.Name == teamName);

                        if (team == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                        Console.WriteLine($"{team.Name} - {team.Rating}");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
