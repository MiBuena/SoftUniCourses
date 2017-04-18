using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExamSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinute = int.Parse(Console.ReadLine());
            string dayPart = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());


            if (startHour + durationHours < 13)
            {
                if (startMinute + durationMinutes < 60)
                {
                    int hour = startHour + durationHours;
                    int minutes = startMinute + durationMinutes;
                    Console.WriteLine("{0:00}:{1:00}:{2}", hour, minutes, dayPart);
                }
                else
                {
                    int hour = startHour + durationHours+1;
                    int minutes = startMinute + durationMinutes-60;

                    if (dayPart == "AM")
                    {
                        dayPart = "PM";
                    }
                    else
                    {
                        dayPart = "AM";
                    }

                    Console.WriteLine("{0:00}:{1:00}:{2}", hour, minutes, dayPart);
                }
                
            }
            else
            {
                if (startMinute + durationMinutes < 60)
                {
                    int hour = (startHour + durationHours)-12;
                    int minutes = startMinute + durationMinutes;

                    if (dayPart == "AM")
                    {
                        dayPart = "PM";
                    }
                    else
                    {
                        dayPart = "AM";
                    }

                    Console.WriteLine("{0:00}:{1:00}:{2}", hour, minutes, dayPart);
                }
                else
                {
                    int hour = (startHour + durationHours) - 12 + 1;

                    if (hour > 12)
                    {
                        hour = hour - 12;
                    }
                    else
                    {
                        if (dayPart == "AM")
                        {
                            dayPart = "PM";
                        }
                        else
                        {
                            dayPart = "AM";
                        }
                    }

                    int minutes = startMinute + durationMinutes - 60;

                    Console.WriteLine("{0:00}:{1:00}:{2}", hour, minutes, dayPart);
                }
            }
        }
    }
}

