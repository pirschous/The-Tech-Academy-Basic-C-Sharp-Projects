using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSub
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate 2 opbjects of Employee class and assign value
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "James",
                LastName = "Pirch"
            };

            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Stephanie",
                LastName = "Pirsch"
            };

            // Compare the 2 Employee objects using the overload operator
            bool areEqual = employee1 == employee2;

            // Display results
            Console.WriteLine("Are the employees equal? " + areEqual);

            // Wait for user input to close console
            Console.ReadLine();
        }
    }
}
