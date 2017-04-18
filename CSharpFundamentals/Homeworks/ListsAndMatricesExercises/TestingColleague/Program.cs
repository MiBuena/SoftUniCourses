using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var comand = Console.ReadLine().Split(' ').ToList();
            while (comand[0] != "print")
            {
                var pos = 0;
                long element = 0;
                var end = nums.Count;
                switch (comand[0])
                {
                    case "add":
                        pos = int.Parse(comand[1]);
                        if (pos > nums.Count)
                            break;
                        element = long.Parse(comand[2]);
                        nums.Insert(pos, element);
                        break;
                    case "addMany":
                        pos = int.Parse(comand[1]);
                        if (pos > nums.Count)
                            break;
                        for (int i = comand.Count - 1; i >= 2; i--)
                            nums.Insert(pos, long.Parse(comand[i]));
                        break;
                    case "contains":
                        element = long.Parse(comand[1]);
                        Console.WriteLine(nums.IndexOf(element));
                        break;
                    case "remove":
                        pos = int.Parse(comand[1]);
                        nums.RemoveAt(pos);
                        break;
                    case "shift":
                        pos = int.Parse(comand[1]);
                        var result = nums.Skip(pos).ToList();
                        for (int i = 0; i < pos; i++)
                            result.Add(nums[i]);
                        nums = result;
                        break;
                    case "sumPairs":
                        List<long> results = new List<long>();
                        if (nums.Count % 2 != 0)
                            end = nums.Count - 1;

                        for (int i = 0; i < end; i += 2)
                            results.Add(nums[i] + nums[i + 1]);
                        if (nums.Count % 2 != 0)
                            results.Add(nums.Last());
                        nums = results;
                        break;
                    default: Console.WriteLine(); break;
                }
                comand = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");

        }
    }
}