using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Apple", "Banana", "Orange", "Mango" };

            Console.WriteLine("Select an index of the string Array:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {

                Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);

            }
            else
            {

                Console.WriteLine("Invalid index. Please select a valid index.");

            }

            int[] intArray = { 101, 202, 303, 404, 505 };

            Console.WriteLine("Select an index of the integer Array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex >= 0 && intIndex < intArray.Length)
            {

                Console.WriteLine("Integer at index " + intIndex + ": " + intArray[intIndex]);

            }
            else
            {

                Console.WriteLine("Invalid index. Please select a valid index.");

            }

            List<string> stringList = new List<string> { "Cat", "Dog", "Goldfish", "Bunny" };
            Console.WriteLine("Select an index of the string List:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            if (listIndex >= 0 && listIndex < stringList.Count)
            {

                Console.WriteLine("Content at index " + listIndex + ": " + stringList[listIndex]);

            }
            else
            {

                Console.WriteLine("Invalid index. Please select a valid index.");

            }

            Console.ReadLine();
                
            
        }
    }
}
