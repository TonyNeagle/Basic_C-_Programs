using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer for the operations
            Console.Write("Enter an integer to perform math operations on: ");

            // Read the user input string and convert it into an integer variable
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Instantiate the MathOperations class to access its object methods
            MathOperations math = new MathOperations();

            // Call the first method and store its returned integer
            int doubleResult = math.DoubleNumber(userNumber);
            // Output the multiplication result to the console screen
            Console.WriteLine("Result of doubling your number: " + doubleResult);

            // Call the second method and store its returned integer
            int addResult = math.AddFifty(userNumber);
            // Output the addition result to the console screen
            Console.WriteLine("Result of adding 50 to your number: " + addResult);

            // Call the third method and store its returned integer
            int subtractResult = math.SubtractFive(userNumber);
            // Output the subtraction result to the console screen
            Console.WriteLine("Result of subtracting 5 from your number: " + subtractResult);

            // Keep the console window open until a key is pressed (useful for debugging)
            Console.ReadKey();
        }
    }
}
