using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByTwo
{
    public class MyClass
    {
        // Void method that divided the input by 2
        public void DivideByTwo(int input)
        { 
            
            int result = input / 2;
            Console.WriteLine("Result: " + result);
        }

        //Method with output parameters
        public void Multiply(int a, int b, out int product)
        {
            product = a * b;
        }

        // Method overload
        public void Multiply(int a, int b)
        {
            int product = a * b;
            Console.WriteLine("Product: " + product);
        }
    }

    // Static class decleration
    public static class StaticClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
    }
}
