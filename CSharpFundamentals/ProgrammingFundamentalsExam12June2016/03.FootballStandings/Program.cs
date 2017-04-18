using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _03.FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string key = Console.ReadLine();

            Dictionary<string, BigInteger> pointsDictionary = new Dictionary<string, BigInteger>();

            Dictionary<string, BigInteger> goalsDictionary = new Dictionary<string, BigInteger>();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "final")
                {
                    break;
                }

                List<string> teamsNames = GetTeamsNames(line, key);
                //List<string>teamsNames = GetTeamNames1(line, key);

                BigInteger[] result = GetResult(line);

                if (goalsDictionary.ContainsKey(teamsNames[0]))
                {
                    goalsDictionary[teamsNames[0]] += result[0];
                }
                else
                {
                    goalsDictionary.Add(teamsNames[0], result[0]);
                }

                if (goalsDictionary.ContainsKey(teamsNames[1]))
                {
                    goalsDictionary[teamsNames[1]] += result[1];
                }
                else
                {
                    goalsDictionary.Add(teamsNames[1], result[1]);
                }

                if (!pointsDictionary.ContainsKey(teamsNames[0]))
                {
                    pointsDictionary.Add(teamsNames[0], 0);
                }

                if (!pointsDictionary.ContainsKey(teamsNames[1]))
                {
                    pointsDictionary.Add(teamsNames[1], 0);
                }

                if (result[0] > result[1])
                {
                    pointsDictionary[teamsNames[0]] += 3;
                }
                else if (result[0] < result[1])
                {
                    pointsDictionary[teamsNames[1]] += 3;
                }
                else
                {
                    pointsDictionary[teamsNames[0]] += 1;
                    pointsDictionary[teamsNames[1]] += 1;
                }
            }

            var orderedLeague = pointsDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            var mostGoals = goalsDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3);

            BigInteger place = 1;

            Console.WriteLine("League standings:");

            foreach (var team in orderedLeague)
            {
                Console.WriteLine($"{place++}. {team.Key} {team.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in mostGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        private static List<string> GetTeamNames1(string line, string key)
        {
            List<string> a =new List<string>();

            int index = line.IndexOf(key);

            index += key.Length;

            int index2 = line.IndexOf(key, index);

            string teamName1 = line.Substring(index, index2 - index);

            a.Add(teamName1.ToUpper());

            int index3 = line.IndexOf(key, index2+1) + key.Length;

            int index4 = line.IndexOf(key, index3);

            string teamName2 = line.Substring(index3, index4 - index3);

            a.Add(teamName2.ToUpper());

            ReverseTeamsNames(a);

            return a;



        }

        private static BigInteger[] GetResult(string line)
        {
            BigInteger[] score = new BigInteger[2];

            string text = line;
            string pattern = @" (\d+):(\d+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);



            foreach (Match element in matches)
            {
                score[0] = (BigInteger.Parse(element.Groups[1].ToString()));
                score[1] = (BigInteger.Parse(element.Groups[2].ToString()));
            }

            return score;
        }

        private static List<string> GetTeamsNames(string line, string key)
        {
            List<string> teams = new List<string>();

            string text = line;
            string escape = Regex.Escape(key);
            string pattern = escape + @"(.*?)" + escape;
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            int index = 0;
            foreach (Match element in matches)
            {
                teams.Add(element.Groups[1].ToString().ToUpper());
            }

            ReverseTeamsNames(teams);

            return teams;

        }

        private static void ReverseTeamsNames(List<string> teams)
        {
            for (int i = 0; i < teams.Count; i++)
            {

                    char[] a = teams[i].ToCharArray();

                    string b = string.Join("", a.Reverse());

                    teams[i] = b;
               
 
            }
        }
    }
}

