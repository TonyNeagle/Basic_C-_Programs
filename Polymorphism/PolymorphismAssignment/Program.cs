using System;

namespace QuittableApp
{
    class Program
    {
        
        static void Main(string[] args) // The entry point of the application where execution begins
        {
            
            IQuittable quittingEmployee = new Employee() // Create an instance of Employee and assign it to an IQuittable reference, demonstrating polymorphism
            {
                FirstName = "Peter", // Set the FirstName property of the Employee instance to "Peter"
                LastName = "Smith" // Set the LastName property of the Employee instance to "Smith"
            };
      
            quittingEmployee.Quit(); // Call the Quit method on the quittingEmployee instance, which will execute the implementation defined in the Employee class.

            Console.WriteLine("\nPress any key to exit..."); // Prompt the user to press any key before closing the console window, allowing them to see the output before the program terminates
            Console.ReadKey(); // Wait for the user to press a key before closing the console window
        }
    }
}
