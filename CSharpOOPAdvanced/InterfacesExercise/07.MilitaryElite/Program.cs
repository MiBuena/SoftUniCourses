using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _07.MilitaryElite.Interfaces;
using _07.MilitaryElite.Models;

namespace _07.MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<ISoldier> soldiersCollection = new List<ISoldier>();

            while (true)
            {

                string command = Console.ReadLine().Trim();

                if (command == "End")
                {
                    break;
                }

                string[] parameters = command.Split(' ').ToArray();


                if (parameters[0] == "Private")
                {
                    string id = parameters[1];
                    string firstName = parameters[2];
                    string lastName = parameters[3];
                    decimal salary = decimal.Parse(parameters[4]);

                    IPrivate a = new Private(id, firstName, lastName, salary);

                    soldiersCollection.Add(a);
                }
                else if (parameters[0] == "LeutenantGeneral")
                {
                    string id = parameters[1];
                    string firstName = parameters[2];
                    string lastName = parameters[3];
                    decimal salary = decimal.Parse(parameters[4]);

                    ILeutenantGeneral leutenant = new LeutenantGeneral(id, firstName, lastName, salary);


                    for (int i = 5; i < parameters.Length; i++)
                    {
                        ISoldier privateOfficer = soldiersCollection.FirstOrDefault(x => x.Id == parameters[i]);

                        leutenant.PrivatesCollection.Add(privateOfficer);
                    }

                    soldiersCollection.Add(leutenant);
                }
                else if (parameters[0] == "Engineer")
                {

                    string id = parameters[1];
                    string firstName = parameters[2];
                    string lastName = parameters[3];
                    decimal salary = decimal.Parse(parameters[4]);
                    string corps = parameters[5];

                    if (corps == "Airforces" || corps == "Marines")
                    {
                        IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);


                        for (int i = 6; i < parameters.Length; i += 2)
                        {
                            IRepair repair = new Repair(parameters[i], int.Parse(parameters[i + 1]));
                            engineer.RepairsCollection.Add(repair);
                        }

                        soldiersCollection.Add(engineer);
                    }

                }
                else if (parameters[0] == "Commando")
                {
                    string id = parameters[1];
                    string firstName = parameters[2];
                    string lastName = parameters[3];
                    decimal salary = decimal.Parse(parameters[4]);
                    string corps = parameters[5];

                    if (corps == "Airforces" || corps == "Marines")
                    {
                        ICommando commando = new Commando(id, firstName, lastName, salary, corps);


                        for (int i = 6; i < parameters.Length; i += 2)
                        {
                            string state = parameters[i + 1];

                            if (state == "inProgress" || state == "Finished")
                            {
                                IMission mission = new Mission(parameters[i], parameters[i + 1]);
                                commando.MissionsCollection.Add(mission);
                            }
                        }

                        soldiersCollection.Add(commando);
                    }

                }
                else
                {
                    string id = parameters[1];
                    string firstName = parameters[2];
                    string lastName = parameters[3];
                    string codeNumber = parameters[4];

                    ISoldier a = new Spy(id, firstName, lastName, codeNumber);

                    soldiersCollection.Add(a);
                }
            }

            foreach (var element in soldiersCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
