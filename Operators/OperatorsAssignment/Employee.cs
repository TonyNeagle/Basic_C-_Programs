using System;

namespace EmployeeApp
{
    public class Employee
    {
        
        public int Id { get; set; } // Unique identifier for the employee
        public string FirstName { get; set; }   // Employee's first name
        public string LastName { get; set; }    // Employee's last name

        public static bool operator ==(Employee emp1, Employee emp2) // Overload the '==' operator to compare two Employee objects
        { 
            return emp1.Id == emp2.Id; // Two employees are considered equal if their IDs match
        }

        public static bool operator !=(Employee emp1, Employee emp2) // Overload the '!=' operator beacause when we overload '==', we must also overload '!=' to maintain consistency
        {
            return emp1.Id != emp2.Id; // invert the logic of '==' operator to maintain consistency
        }
    }
}
