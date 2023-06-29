using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user for a number to perfom the operation
            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());

            // Creat an instance of the Operators class
            Operators operators = new Operators();

            // Calls each method and displays the integer
            int squaredNumber = operators.Square(userInput);
            Console.WriteLine($"Squared number: {squaredNumber}");

            int doubledNumber = operators.Double(userInput);
            Console.WriteLine($"Doubled number: {doubledNumber}");

            int numberPlus = operators.Add(userInput);
            Console.WriteLine($"Number plus twenty five: {numberPlus}");

            Console.ReadLine();
        }
    }
}
