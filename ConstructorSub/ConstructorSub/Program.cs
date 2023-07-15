using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSub
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creats a const variable
            const int aConstVariable = 10;

            // Creates a variable using "var"
            var person = new Person("James", "Pirsch");

            Console.WriteLine(aConstVariable);
            Console.WriteLine(person.GetFullName());
            Console.ReadLine();
        }
    }
}
