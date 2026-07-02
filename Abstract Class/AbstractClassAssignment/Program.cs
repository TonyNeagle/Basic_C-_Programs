using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        //  instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.
        static void Main(string[] args)
        {
            Employee employee = new Employee // create an instance of the Employee class
            {
                FirstName = "Sample",   // set the FirstName property to "Sample"   
                LastName = "Student"   // set the LastName property to "Student"
            };
            employee.SayName(); // call the SayName() method to print the employee's full name to the console
            Console.ReadLine(); // wait for user input before closing the console window
        }
    }
}
