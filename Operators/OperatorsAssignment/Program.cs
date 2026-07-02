using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" }; // Create the first employee object with ID 1
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" }; // Create the second employee object with ID 2

            // Check if they are equal using the overloaded '==' operator
            if (emp1 == emp2)   // This will call the overloaded '==' operator to compare emp1 and emp2 based on their IDs
            {
                Console.WriteLine("The employees are equal because their IDs match.");  // If the IDs match, this message will be printed
            }
            else
            {
                Console.WriteLine("The employees are not equal because their IDs don't match.");  // If the IDs do not match, this message will be printed
            }
            Console.ReadKey();
        }
    }
}
