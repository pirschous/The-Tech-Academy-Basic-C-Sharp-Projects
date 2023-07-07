using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSub
{
    class Employee : IQuittable
    {

        public void Quit()

        // Implement the Quit() method from the IQuittable interface
        {
            Console.WriteLine("Employee is quitting.");
            // Additional logic can be added here if needed
        }
    }
}
