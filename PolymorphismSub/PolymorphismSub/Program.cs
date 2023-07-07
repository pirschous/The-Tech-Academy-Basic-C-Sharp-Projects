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
            Employee employee = new Employee { Name = "James" };

            // Creat an object of type IQuittable and assign employee instance
            IQuittable quittable = employee;

            // Call the Quit() method on the quittable object
            quittable.Quit();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
