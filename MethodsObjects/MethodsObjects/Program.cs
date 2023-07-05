using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "James",
                LastName = "Pirsch"
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
