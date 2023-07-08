using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    // Enum for days of the week
    public enum DayofWeek
    {
        Sunday,
        Monday, 
        Tuesday, 
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enther the current day of the week: ");
                string input = Console.ReadLine();

                // Parsing the suer input and assigning it to the enum variable
                DayofWeek currentDay;
                if (!Enum.TryParse(input, true, out currentDay))
                {
                    throw new Exception();
                }

                Console.WriteLine("The current day is: " + currentDay);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
