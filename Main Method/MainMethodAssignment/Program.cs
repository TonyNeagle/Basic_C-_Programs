using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOps class so we can access its methods
            MathOps mathObject = new MathOps();

            // 1. Call the first method with an integer
            int intResult = mathObject.PerformMath(5);
            Console.WriteLine("Integer method (5 + 10): " + intResult);

            // 2. Call the second method with a decimal
            // Using 'm' suffix to denote a decimal literal
            int decimalResult = mathObject.PerformMath(10.5m);
            Console.WriteLine("Decimal method (10.5 * 5): " + decimalResult);

            // 3. Call the third method with a string
            int stringResult = mathObject.PerformMath("20");
            Console.WriteLine("String method (20 - 2): " + stringResult);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
