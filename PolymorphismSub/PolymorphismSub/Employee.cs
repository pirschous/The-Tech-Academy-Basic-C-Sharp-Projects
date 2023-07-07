using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSub
{
    public class Employee : IQuittable
    {

        public string Name { get; set; }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee {0} is quitting.", Name);
            // Additional logic can be added here if needed
        }
    }
}
