using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOpperation mathOpperation = new MathOpperation();

            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number (press Enter to skip):");
            string input = Console.ReadLine();

            int num2;

            if (string.IsNullOrEmpty(input))
            {
                // If the user skipped, set to default value
                num2 = 0;
            }
            else
            {
                // Parse the user's input as an int
                num2 = int.Parse(input);
            }

            // Call the PerformOperation method, passing in the one or two numbers
            int result = mathOpperation.PerformOperation(num1, num2);

            // Displat the result
            Console.WriteLine("The result is: " + result);

            Console.ReadLine();
        }
    }
}
