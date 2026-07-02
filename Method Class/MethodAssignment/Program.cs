using System;

class Program
{
    static void Main()
    {
        // Instantiate the class
        Calculator calc = new Calculator();

        // Get the first required number
        Console.Write("Enter the first number (required for an addition of your choice): ");
        string input1 = Console.ReadLine();
        int num1 = int.Parse(input1);

        // Get the second optional number
        Console.Write("Enter the second number (or press any key to add 10): ");
        string input2 = Console.ReadLine();

        int result;

        // Check if the user skipped the second number
        if (string.IsNullOrWhiteSpace(input2))
        {
            // Call the method with only one parameter
            result = calc.AddNumbers(num1);
        }
        else
        {
            // Call the method with both parameters
            int num2 = int.Parse(input2);
            result = calc.AddNumbers(num1, num2);
        }

        // Display the math result
        Console.WriteLine($"Result: {result}");

        // Wait for user input before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public class Calculator
{
    public int AddNumbers(int number1, int number2 = 10)
    {        return number1 + number2;    }    
}
