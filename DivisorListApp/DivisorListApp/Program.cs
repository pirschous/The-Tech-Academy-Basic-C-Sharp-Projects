using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                Console.Write("Enter a number to divide each element in the list: ");
                string input = Console.ReadLine();
                int divisor = int.Parse(input);



                Console.WriteLine("Results:");
                foreach (int number in numbers)
                {
                    int result = number / divisor;

                    Console.WriteLine($"{number} divided by {divisor} is {result}");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: The number you entered can't be divided by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: This is an invalid input. Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Program has emerged from the try/catch block and continued execution.");
            }
            Console.ReadLine();
        }
    }
}
