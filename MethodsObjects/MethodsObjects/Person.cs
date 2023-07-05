using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects
{
    class Person
    {
        // Gives it two properties, FirstName and LastName
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        // Gives class a void method called SayName()
        public void SayName()
        {
            // Write the persons full name
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
