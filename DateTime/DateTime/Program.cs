using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);

            // Ask the user for a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int hoursToAdd;

            // Validate the user's input
            if (int.TryParse(input, out hoursToAdd))
            {
                // Calculate the future date and time
                DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);

                // Print the future dat and time to the console
                Console.WriteLine("Future date and time in {0} hours: {1}", hoursToAdd, futureDateTime);
            }
         
            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
