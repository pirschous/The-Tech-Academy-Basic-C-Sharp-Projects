using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the IntegerInput class
            MathOpp mathOpp = new MathOpp();

            // Calls the PerformOperation method with an integer displays result
            int inputInt = 20;
            int resultInt = mathOpp.PerformOperation(inputInt);
            Console.WriteLine("Integer result: " + resultInt);

            // Calls the PerformOperation method with a decimal and displays result
            decimal inputDecimal = 8.5m;
            int resultDecimal = mathOpp.PerformOperation(inputDecimal);
            Console.WriteLine("Decimal result: " + resultDecimal);

            // Calls the PerformOperation method with a string that represents an integer
            string inputString = "15";
            int resultString = mathOpp.PerformOperation(inputString);
            Console.WriteLine("String result: " + resultString);

            Console.ReadLine();
        }
    }
}
