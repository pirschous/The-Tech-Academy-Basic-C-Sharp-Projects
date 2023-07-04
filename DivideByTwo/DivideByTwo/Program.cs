using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Insantiates ...
            MyClass myObject = new MyClass();

            // User enters number
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Call DivideByTwo method and display it
            myObject.DivideByTwo(number);

            // Call Multiply method with output parameters
            int product;
            myObject.Multiply(5, 10, out product);
            Console.WriteLine("Output parameter product: " + product);

            // Call Multiply method overload
            myObject.Multiply(3, 7);

            // Call StaticMethod from StaticClass
            StaticClass.StaticMethod();

            // Wait for user input before closing the console window
            Console.ReadLine();

        }
    }
}
