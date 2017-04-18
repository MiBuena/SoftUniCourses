using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ListIterator
{
    class CommandExecutor
    {
        private ListIterator<string> ListIterator; 



        public string ExecuteCommand(string [] parameters)
        {
            string result = "";

            switch (parameters[0])
            {
                case "Create":
                    CreateCollection(parameters);
                    break;
                case "Move":
                    result = this.ListIterator.Move().ToString() + "\n";
                    break;
                case "Print":
                    this.ListIterator.Print();
                    break;
                case "HasNext":
                    result= this.ListIterator.HasNext().ToString() + "\n";
                    break;
                case "PrintAll":
                    PrintAll();
                    break;
            }

            return result;
        }

        private void PrintAll()
        {
            foreach (var element in this.ListIterator)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }


        private void CreateCollection(string[] parameters)
        {
            if (parameters.Length == 1)
            {
                List<string> emptyData = new List<string>();

                this.ListIterator = new ListIterator<string>(emptyData);
            }
            else
            {
                List<string> data = parameters.Skip(1).ToList();

                this.ListIterator = new ListIterator<string>(data);
            }
        }
    }
}
