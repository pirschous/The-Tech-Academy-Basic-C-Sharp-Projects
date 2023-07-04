using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class MathOperations
    {
        // Create a void method named 
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber * 2;

            // Display the second integer to the screen
            Console.WriteLine($"Second number: { secondNumber}");
            Console.ReadLine();
        }
    }
}
