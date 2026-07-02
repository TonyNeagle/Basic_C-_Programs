using System;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // --- Person 1 Details ---
            Console.WriteLine("Person 1");
            // Get hourly rate
            Console.WriteLine("Hourly Rate?");
            string rate1Input = Console.ReadLine();
            decimal hourlyRate1 = Convert.ToDecimal(rate1Input);
            // Get hours worked per week
            Console.WriteLine("Hours worked per week?");
            string hours1Input = Console.ReadLine();
            decimal hoursWorked1 = Convert.ToDecimal(hours1Input);

            // --- Person 2 Details ---
            Console.WriteLine("Person 2");
            // Get hourly rate
            Console.WriteLine("Hourly Rate?");
            string rate2Input = Console.ReadLine();
            decimal hourlyRate2 = Convert.ToDecimal(rate2Input);
            // Get hours worked per week
            Console.WriteLine("Hours worked per week?");
            string hours2Input = Console.ReadLine();
            decimal hoursWorked2 = Convert.ToDecimal(hours2Input);

            // --- Calculations ---
            // Calculate annual salary (Hourly Rate * Hours per Week * 52 Weeks)
            decimal annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
            decimal annualSalary2 = hourlyRate2 * hoursWorked2 * 52;

            // --- Output Results ---
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // --- Comparison ---
            // Check if Person 1 makes more than Person 2
            Console.WriteLine("Person 1 makes more money than Person 2:");
            bool isPerson1Richter = annualSalary1 > annualSalary2;
            Console.WriteLine(isPerson1Richter);

            // Keep console open
            Console.ReadLine();
        }
    }
}
