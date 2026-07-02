using System;

namespace QuittableApp
{
   
    public class Employee : IQuittable // Employee class implements the IQuittable interface, meaning it must provide an implementation for the Quit method
    {
        public string FirstName { get; set; } // Auto-implemented property to store the employee's first name

        public string LastName { get; set; } // Auto-implemented property to store the employee's last name

        public void Quit() // this provides the implementation for the Quit method defined in the IQuittable interface
        {
            
            Console.WriteLine($"{FirstName} {LastName} has resigned from the company."); // When Quit is called, it outputs a message to the console indicating that the employee has resigned, using their first and last name
        }
    }
}

