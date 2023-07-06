using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiates an Employee object in Main() method with firstName and lastName
            Employee employee = new Employee
            {
                FirstName = "James",
                LastName = "Pirsch"
            };

            // Calls the SayName() method on the object
            employee.SayName();
        }
    }
}
