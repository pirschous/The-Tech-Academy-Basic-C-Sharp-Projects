﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MathOpp
    {
        // Method that takes an integer, performs an operation and returns
        public int PerformOperation(int num)
        {

            // Perform a math operation
            int result = num + 10;

            //Return the result as an integer
            return result;
        }

        public int PerformOperation(decimal num)
        {

            // Perform a different math operation
            int result = (int)(num * 2);

            // Return the result as an integer
            return result;
        }

        // Another method that perform a different math operation
        public int PerfromOperation(string input)
        {
            // Converts the string to an integer
            int num = int.Parse(input);
            
            
            // Performs a different math operation
            int result = num - 5;

            // Return the result as an integer
            return result;
        }

        internal int PerformOperation(string inputString)
        {
            throw new NotImplementedException();
        }
    }
}
