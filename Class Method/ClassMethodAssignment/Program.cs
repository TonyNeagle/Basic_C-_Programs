using System;

namespace ClassMethodAssignment
{
    class Program
    {
        // The Main method serves as the entry point for the application
        static void Main(string[] args)
        {
            // Instantiate the non-static MathOperations class using the 'new' keyword
            MathOperations mathOp = new MathOperations();

            // Prompt the user to input a number into the console
            Console.WriteLine("Enter a whole number to divide by 2:");

            // Read user input string and convert it into a 32-bit signed integer
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the void method on the instantiated class, passing the user's number
            mathOp.DivideByTwo(userInput);

            // Declare an integer variable to hold the output from the out parameter method
            int resultFromOut;

            // Call the method containing the 'out' parameter to assign a value to resultFromOut
            mathOp.GetOutputParam(out resultFromOut);

            // Display the assigned value of the out parameter to the console screen
            Console.WriteLine($"Value received from out parameter: {resultFromOut}");

            // Call the overloaded version of the DivideByTwo method by passing a double data type
            mathOp.DivideByTwo(50.5);

            // Call the static method directly from the static class without creating an instance
            StaticHelper.DisplayMessage();

            // Pause program execution to keep the console window open for the user
            Console.ReadLine();
        }
    }
}
