using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class CommandInterpreter
    {

        public string ExecuteCommand(string[] parameters, CustomList<string> customList )
        {
            string commandName = parameters[0];

            switch (commandName)
            {
                case "Add":
                    customList.Add(parameters[1]);
                    return "";
                    break;

                case "Max":
                    return customList.Max() + "\n";
                    break;

                case "Min":
                    return customList.Min() + "\n";
                    break;
                case "Greater":
                    int result = customList.CountGreaterThan(parameters[1]);
                    return result.ToString() + "\n";
                    break;
                case "Swap":
                    int firstIndex = int.Parse(parameters[1]);
                    int secondIndex = int.Parse(parameters[2]);

                    customList.SwaptElements(firstIndex, secondIndex);
                    break;
                case "Contains":
                    return customList.Contains(parameters[1]).ToString() + "\n";
                    break;
                case "Print":
                    return customList.Print() + "\n";
                    break;
                case "Sort":
                    customList.Sort();
                    return "";
                    break;
            }

            return "";


        }
    }
}
