using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSub
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use to create an object of type IQuittable and call the Quit() method

            // Create an instance of the Employee class
            IQuittable employee = new Employee();

            // Call the Quit() method on the quittable object
            employee.Quit();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
