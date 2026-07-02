using System;
using System.Collections.Generic;
using System.Linq; // Required for using lambda expressions and LINQ (.Where)

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list containing 10 Employee objects with Id, FirstName, and LastName
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Michael", LastName = "Scott" },
                new Employee { Id = 5, FirstName = "Pam", LastName = "Beesly" },
                new Employee { Id = 6, FirstName = "Jim", LastName = "Halpert" },
                new Employee { Id = 7, FirstName = "Dwight", LastName = "Schrute" },
                new Employee { Id = 8, FirstName = "Joe", LastName = "Williams" },
                new Employee { Id = 9, FirstName = "Angela", LastName = "Martin" },
                new Employee { Id = 10, FirstName = "Kevin", LastName = "Malone" }
            };

            // 1. Foreach Loop: Create a new list for employees named "Joe"
            List<Employee> joesForeach = new List<Employee>();
            foreach (Employee emp in employees)
            {
                // Check if the current employee's FirstName property matches "Joe"
                if (emp.FirstName == "Joe")
                {
                    // Add the matching employee object to our new list
                    joesForeach.Add(emp);
                }
            }

            // Print the results from the foreach loop filter
            Console.WriteLine("Employees named Joe (via foreach loop):");
            foreach (Employee joe in joesForeach)
            {
                Console.WriteLine($"- {joe.FirstName} {joe.LastName}");
            }

            // 2. Lambda Expression: Perform the same filter for "Joe"
            // The lambda expression (e => e.FirstName == "Joe") evaluates each item in the list
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Print the results from the lambda filter
            Console.WriteLine("\nEmployees named Joe (via lambda expression):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"- {joe.FirstName} {joe.LastName}");
            }

            // 3. Lambda Expression: Filter for employees with an Id greater than 5
            // The lambda expression (e => e.Id > 5) evaluates each item's Id property
            List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            // Print the results from the ID filter
            Console.WriteLine("\nEmployees with an ID greater than 5:");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine($"- ID: {emp.Id}, {emp.FirstName} {emp.LastName}");
            }

            // Keep the console window open during execution
            Console.ReadLine();
        }
    }
}
