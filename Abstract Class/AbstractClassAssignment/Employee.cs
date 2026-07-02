using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{

  
    public class Employee : Person    // Employee class that inherits from the abstract Person class
    {
        // Implement the SayName() method inside of the Employee class.
        public override void SayName() // override the abstract method from the Person class
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}"); // print the employee's full name to the console
        }
    }
}
