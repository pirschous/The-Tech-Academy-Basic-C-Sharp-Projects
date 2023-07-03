using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerOperations
{
    class MathOperations
    {

        // Defins a void method that takes in two integers
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first number and display the second number
            int result = firstNumber + 5;
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }
}
