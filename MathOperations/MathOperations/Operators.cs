using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Operators
    {
        // Method 1 is to square the input
        public int Square(int number)
        {
            return number * number;
        }

        //Method 2 is to double the input
        public int Double(int number)
        {
            return number * 2;
        }

        // Method 3 is to add 25 to the input
        public int Add(int number)
        {
            return number + 25;
        }
    }
}
