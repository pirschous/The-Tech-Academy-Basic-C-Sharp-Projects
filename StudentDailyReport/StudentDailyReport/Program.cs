using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Rep");

            // Ask and save student's name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Ask and save the course name
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Ask and save the page number
            Console.WriteLine("What page number are you on?");
            int pageNumber = int.Parse(Console.ReadLine());

            // Ask and save if the student needs help
            Console.WriteLine("Do you need help with anything? Please enter true or false.");
            bool needsHelp = bool.Parse(Console.ReadLine());

            // Ask and save good experience
            Console.WriteLine("Were ther any positive experiences you would like to share with the instructors?");
            string positiveExperences = Console.ReadLine();

            // Ask and save for additional feedback
            Console.WriteLine("Is there any other feedback that you would like to provide to the instructors?");
            string feedback = Console.ReadLine();

            // Ask and save number of hours studied
            Console.WriteLine("How many hours did you study today?");
            float hoursStudied = float.Parse(Console.ReadLine());

            // Print the closing message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to you shortly. Have a great day!");

            // Wait for user input to exit the program
            Console.ReadLine();
            
        }
    }
}
