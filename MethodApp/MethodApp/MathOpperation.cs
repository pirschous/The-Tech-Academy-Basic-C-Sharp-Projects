using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp
{
    class MathOpperation
    {
        //Crate method that takes 2 integers as [arameters
        //Make the second one number optional with a default value of 0
        public int PerformOperation(int number1, int number2 = 0)
        {
            // Perform math operation
            int result = number1 + number2;

            return result;

        }
    }
}
