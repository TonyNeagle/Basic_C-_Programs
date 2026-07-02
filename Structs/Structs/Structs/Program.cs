using System;

namespace StructConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //  create an object of data type Number and assign an amount to it.
            Number myNumber = new Number();
            myNumber.Amount = 123.45m; // Assign a decimal value to the Amount property



            // Print the Amount property to the console
            Console.WriteLine($"The amountr assigned is:{ myNumber.Amount}");


            // Keep the console window open so the user can read the output
            Console.ReadLine();
        }
    }
}

