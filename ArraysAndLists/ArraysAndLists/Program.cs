using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            // Creates the one-dimensional Array of strings
            string[] stringArray = { "Apple", "Banana", "Orange", "Mango" };

            // Asks user to select an index
            Console.WriteLine("Select an index of the string Array:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Checks if the selected index is in the Array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Displays the string at the selected index
                Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);

            }
            else
            {
                // Displays when index isn't there
                Console.WriteLine("Invalid index. Please select a valid index.");

            }

            // Create a one dimensional Array of integers
            int[] intArray = { 101, 202, 303, 404, 505 };

            // Asks user to select an index
            Console.WriteLine("Select an index of the integer Array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Displays the string at the selected index
                Console.WriteLine("Integer at index " + intIndex + ": " + intArray[intIndex]);

            }
            else
            {
                // Displays when index isn't there
                Console.WriteLine("Invalid index. Please select a valid index.");

            }

            // Creates a list of strings
            List<string> stringList = new List<string> { "Cat", "Dog", "Goldfish", "Bunny" };

            Console.WriteLine("Select an index of the string List:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Displays the string at the selected index
                Console.WriteLine("Content at index " + listIndex + ": " + stringList[listIndex]);

            }
            else
            {
                // Displays when index isn't there
                Console.WriteLine("Invalid index. Please select a valid index.");

            }

            Console.ReadLine();
                
            
        }
    }
}
