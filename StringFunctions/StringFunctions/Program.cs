using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "James ";
            string lastName = "Pirsch ";
            string stateBorn = "Hawaii";
            string name = string.Concat(firstName, lastName, stateBorn);// Concatanates strings into one
            Console.WriteLine(name);
            
            string txt = "i am yelling!";
            Console.WriteLine(txt.ToUpper());// Transforms string to upper case
            Console.ReadLine();

            StringBuilder paragraphBuilder = new StringBuilder();

            
            paragraphBuilder.Append("This is the first sentence. ");
            paragraphBuilder.Append("Here's the second sentence. ");
            paragraphBuilder.Append("The third sentence. ");
            paragraphBuilder.Append("Finally, the fourth sentence.");

            // Convert the stringbuilder to a paragraph
            string paragraph = paragraphBuilder.ToString();

            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
