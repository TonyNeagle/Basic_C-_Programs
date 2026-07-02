using System;

namespace MainMethodAssignment
{
    public class MathOps
    {
        // Method 1: Takes an integer, adds 10, and returns the result
        public int PerformMath(int number)
        {
            return number + 10;
        }

        // Method 2: Takes a decimal, multiplies by 5, and returns the result as an integer
        // Overloading occurs here because the name is the same but the parameter is a decimal
        public int PerformMath(decimal number)
        {
            // We cast the result to (int) to meet the integer return requirement
            return (int)(number * 5);
        }

        // Method 3: Takes a string, converts it to an int, subtracts 2, and returns the result
        // Overloading occurs here with a string parameter
        public int PerformMath(string number)
        {
            // Convert string to integer. Note: This assumes the string is a valid number.
            int convertedNum = Convert.ToInt32(number);
            return convertedNum - 2;
        }
    }
}

