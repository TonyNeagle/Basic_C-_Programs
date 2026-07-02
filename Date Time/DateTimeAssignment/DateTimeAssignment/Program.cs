using System;

namespace DateTimeAssignment
{class program
    {
        static void Main(string[] args)
        {
            // Create a DateTime object representing the current date and time
            DateTime currentDateTime = DateTime.Now;
            // Display the current date and time
            Console.WriteLine("Current Date and Time: " + currentDateTime);
            // Ask the user for a number and add it in hours to the current time
            Console.WriteLine("Enter a number of hours to add:");
            // Add the number to the current timeand displaywhat time it will be when adding the number of hours input
            float hoursToAdd = float.Parse(Console.ReadLine());
            Console.WriteLine("New Date and Time will be: " + currentDateTime.AddHours(hoursToAdd));
            Console.ReadLine();


        }
    }

}
