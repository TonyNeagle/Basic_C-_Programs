using System;

namespace BooleanComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- WHILE LOOP SECTION ---

            int whileCounter = 0; // This variable will be used in our boolean comparison to control the loop


            while (whileCounter < 3) // This is the boolean comparison that controls the loop while the counter is less than 3
            {
                Console.WriteLine($"While loop iteration: {whileCounter}"); // This line will execute as long as the boolean condition
                                                                            // (whileCounter < 3) is true and will print the current value of whileCounter to the console.

                whileCounter++; // This line increases the value of whileCounter by 1 in each iteration, which will eventually make the condition (whileCounter < 3) false and exit the loop.
            }

            // --- DO-WHILE LOOP ---

            int doWhileCounter = 0; //initializing the counter for the do-while loop


            do // The 'do' block will execute at least once regardless of the condition, and then it will check the condition at the end of the block.
            {

                Console.WriteLine($"Do-While loop iteration: {doWhileCounter}"); // This line will execute at least once and will print the current value of doWhileCounter to the console.

                doWhileCounter++; // This line increases the value of doWhileCounter by 1 in each iteration, which will eventually make the condition (doWhileCounter < 3) false and exit the loop.

            
            } while (doWhileCounter < 3); // This is the boolean comparison that controls the loop. The loop will continue to execute as long as doWhileCounter is less than 3.

          
            Console.WriteLine("Press any key to exit..."); // This line prompts the user to press a key before the console window closes, allowing them to see the output of the loops before exiting the program.
            Console.ReadKey(); // This line waits for the user to press a key, which prevents the console window from closing immediately after the loops have finished executing.
        }
    }
}
