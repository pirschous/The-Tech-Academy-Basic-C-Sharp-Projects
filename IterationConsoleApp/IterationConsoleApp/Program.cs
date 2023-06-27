using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[5];

            Console.WriteLine("Please enter some text:");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Loop with the < operator. Count:" + count);
                count++;
            }

            count = 0;
            while (count <= 5)
            {
                Console.WriteLine("Loop with <= operator. Count: " + count);
                count++;
            }

            //Console.WriteLine("Press any key to exit...");

            while (true)
            {
                Console.WriteLine("Press 'Q' to exit the infinite loop.");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Q")
                {
                    break;
                }
            }

            List<string> stringList = new List<string> { "Pokemon", "Baseball", "Soccer", "Basketball", "Rugby" };

            Console.WriteLine("Enter some text to search within the list:");
            string searchText = Console.ReadLine();

            int foundIndex = -1;
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                Console.WriteLine("Match found at index: " + foundIndex);
            }
            else
            {
                Console.WriteLine("Input is not on the list.");
            }

            while (true)
            {

                Console.WriteLine("Press 'Q' to exit the infinite loop.");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Q")
                {
                    break;
                }
            }

            List<string> stringsList = new List<string> { "butter", "milk", "buttermilk", "yogurt", "cream", "milk", "pudding" };

            Console.WriteLine("Enter text to search in the list:");
            string searchsText = Console.ReadLine();

            List<int> matchingIndicies = new List<int>();

            for (int i = 0; i < stringsList.Count; i++)
            {
                if (stringsList[i].Equals(searchsText, StringComparison.OrdinalIgnoreCase))
                {
                    matchingIndicies.Add(i);
                }
            }

            if (matchingIndicies.Count > 0)
            {
                Console.WriteLine("Match found at indicies: " + string.Join(", ", matchingIndicies));
            }
            else
            {
                Console.WriteLine("Input is not on the list.");
            }

            while (true)
            {

                Console.WriteLine("Press 'Q' to exit the infinite loop please.");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Q")
                {

                    break;
                }
            }

            List<string> stringsLists = new List<string> { "rice", "wheat", "spelt", "rye", "bulghur", "wheat" };

            foreach (string item in stringsLists)
            {

                if (stringsLists.IndexOf(item) == stringsLists.LastIndexOf(item))
                {
                    Console.WriteLine(item + " - this item is unique");
                }
                else
                {
                    Console.WriteLine(item + " - this item is a duplicate");
                }
            }

            while (true)
            {

                Console.WriteLine("Press 'Q' to exit the infinite loop.");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Q")
                {

                    break;
                }

            }
        }
    }
}
