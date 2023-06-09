using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Annonymous Income Comparison Program");
            Console.WriteLine();

            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            double hoursWorkedPerWeek1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            double hoursWorkedPerWeek2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Calculating the annual salaries for Person 1 & 2
            double annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
            double annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            Console.WriteLine("Annual salary for Person 1: $" + annualSalary1);
            Console.WriteLine("Annual salary for Person 2: $" + annualSalary2);

            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + person1MakesMore);

            Console.ReadLine();


        }
    }
}
