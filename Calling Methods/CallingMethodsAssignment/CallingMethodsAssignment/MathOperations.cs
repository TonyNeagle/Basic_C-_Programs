using System;

namespace MathApp
{
    // Defines a public class to hold our mathematical methods
    public class MathOperations
    {
        // Method 1: Takes an integer, multiplies it by 2, and returns the result
        public int DoubleNumber(int inputNumber)
        {
            // Perform multiplication and return the final integer value
            return inputNumber * 2;
        }

        // Method 2: Takes an integer, adds 50 to it, and returns the result
        public int AddFifty(int inputNumber)
        {
            // Perform addition and return the final integer value
            return inputNumber + 50;
        }

        // Method 3: Takes an integer, subtracts 5 from it, and returns the result
        public int SubtractFive(int inputNumber)
        {
            // Perform subtraction and return the final integer value
            return inputNumber - 5;
        }
    }
}
