using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a boolean flag to control the loop. It stays false until we get a valid input.
            bool isValidInput = false;

            // Loop continuously until the user provides a valid age.
            while (!isValidInput)
            {
                // The try block contains the code that might throw an exception.
                try
                {
                    // Prompt the user to enter their age.
                    Console.Write("Please enter your age: ");

                    // Read the user input from the console and convert it from a string to an integer.
                    int age = int.Parse(Console.ReadLine());

                    // Check if the user entered a negative number or zero.
                    if (age <= 0)
                    {
                        // Manually throw an ArgumentOutOfRangeException if the age is not a positive number.
                        throw new ArgumentOutOfRangeException();
                    }

                    // Get the current calendar year.
                    int currentYear = DateTime.Now.Year;

                    // Calculate the birth year by subtracting the age from the current year.
                    int birthYear = currentYear - age;

                    // Display the calculated birth year to the user.
                    Console.WriteLine($"You were born in either {birthYear - 1} or {birthYear}.");

                    // Set the flag to true to break out of the while loop since the input was valid.
                    isValidInput = true;
                }
                // This block catches the specific exception thrown when a user enters zero or a negative number.
                catch (ArgumentOutOfRangeException)
                {
                    // Display an error message telling the user that age must be greater than zero.
                    Console.WriteLine("Error: Age must be a positive number greater than zero. Please try again.\n");
                }
                // This block catches formatting errors, such as when a user enters text instead of digits.
                catch (FormatException)
                {
                    // Display a specific message for invalid input formats.
                    Console.WriteLine("Error: Please enter a valid whole number using digits only. Please try again.\n");
                }
                // This block catches any other unexpected errors that were not caught by the previous blocks.
                catch (Exception ex)
                {
                    // Display a general error message along with the specific system message for debugging.
                    Console.WriteLine($"An unexpected error occurred: {ex.Message} Please try again.\n");
                }
            }

            // Keep the console window open until the user presses a key.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
