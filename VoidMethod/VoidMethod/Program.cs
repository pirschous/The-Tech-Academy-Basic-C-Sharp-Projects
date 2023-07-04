using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations math = new MathOperations();


            // Call the PerformMathOperation method and pass in two numbers
            math.PerformMathOperation(3, 5);

            // Call the PerformMathOperation method, specify the parameters by name
            math.PerformMathOperation(firstNumber: 7, secondNumber: 9);
        }
    }
}
