using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask question
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Check qualifications
            bool qualifiesForInsurance = (age > 15) && !hasDUI && (speedingTickets <= 3);

            // Print result
            Console.WriteLine("Qualified for car insurance: " + qualifiesForInsurance);

            Console.ReadLine(); 
        }
    }
}
