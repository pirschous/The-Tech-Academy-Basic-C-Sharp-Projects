using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comparison using while statement
            int number = 5;
            int limit = 10;

            Console.WriteLine("Using a while statement:");
            while (number < limit)
            {
                Console.WriteLine("Number: " + number);
                number++;
            }
            Console.WriteLine();

            // Comparison using a do-while statement
            int count = 0;
            int target = 3;

            Console.WriteLine("Using a do-while statement:");
            do
            {
                Console.WriteLine("Count: " + count);
                count++;
            } while (count < target);

            Console.ReadLine();
        }
    }
}
