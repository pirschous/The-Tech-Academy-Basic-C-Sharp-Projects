using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates the class
            MathOperations math = new MathOperations();

            // Calls the PerformMathOperation method
            math.PerformMathOperation(17, 23);

            // Calls the PerformMathOperation method, specifying by name
            math.PerformMathOperation(firstNumber: 7, secondNumber: 17);

            // Wait for user input
            Console.ReadLine();
        }
    }
}
