using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSub
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "James", LastName = "Pirsch" },
                new Employee { Id = 2, FirstName = "Joe", LastName = "Schmo" },
                new Employee { Id = 3, FirstName = "Don", LastName = "Juan" },
                new Employee { Id = 4, FirstName = "Willy", LastName = "Wonka" },
                new Employee { Id = 5, FirstName = "Milly", LastName = "Vanilly" },
                new Employee { Id = 6, FirstName = "Joe", LastName = "Dirt" },
                new Employee { Id = 7, FirstName = "John", LastName = "Bon Jovi" },
                new Employee { Id = 8, FirstName = "JC", LastName = "Penny" },
                new Employee { Id = 9, FirstName = "Roger", LastName = "Dodger" },
                new Employee { Id = 10, FirstName = "Lil", LastName = "Spud" },
            };

            Console.WriteLine("Employees with the first name 'Joe': ");
            List<Employee> joeForeach = new List<Employee>();

            // Iterate over each employee esing foreach loop
            foreach (Employee employee in employees)
            {
                // Checks if the employee's first name is 'Joe'
                if (employee.FirstName == "Joe")
                {
                    // Add the employee to the new list
                    joeForeach.Add(employee);
                }
            }

            // Display the employees with the name 'Joe'
            foreach (Employee joe in joeForeach)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmplyees with the first name 'Joe:");
            List<Employee> joesLambda = employees.FindAll(e => e.FirstName == "Joe");

            // Display the employees with the first name 'Joe'
            foreach(Employee joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with Id greater than 5:");
            List<Employee> idsGreaterThan5 = employees.FindAll(e => e.Id > 5);

            // Display the employees with Id greater than 5
            foreach (Employee employee in idsGreaterThan5)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}:");
            }

            Console.ReadLine();

        }
    }
}
