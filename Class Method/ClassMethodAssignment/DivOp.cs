using System;

namespace ClassMethodAssignment
{
    // Define a standard class that can be instantiated into objects
    public class MathOperations
    {
        // A void method that accepts an integer, divides it by 2, and outputs the result
        public void DivideByTwo(int number)
        {
            // Perform integer division on the passed parameter
            int result = number / 2;

            // Output the calculated division result directly to the console screen
            Console.WriteLine($"Input {number} divided by 2 is: {result}");
        }

        // Overloaded method: shares the same name but accepts a 'double' parameter type instead of 'int'
        public void DivideByTwo(double number)
        {
            // Perform floating-point division on the passed parameter
            double result = number / 2;

            // Output the overloaded method calculation result to the console screen
            Console.WriteLine($"Overloaded method (double) result: {result}");
        }

        // A method that uses an 'out' parameter to pass data back to the calling code
        public void GetOutputParam(out int x)
        {
            // Explicitly assign a value to the out parameter; this is mandatory before the method returns
            x = 100;
        }
    }

    // Declare a static class which cannot be instantiated using the 'new' keyword
    public static class StaticHelper
    {
        // A static method belonging to the static class, accessible globally via the class name
        public static void DisplayMessage()
        {
            // Output a specific message to the console screen
            Console.WriteLine("This message comes from a static class!");
        }
    }
}
