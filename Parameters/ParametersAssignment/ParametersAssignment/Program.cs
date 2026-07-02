using ParametersAssignment;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;


namespace EmployeeApp

{

    class Program

    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type “string” as its generic parameter.
            Employee<string> stringEmployee = new Employee<string>();
            //Assign a list of strings as the property value of Things.
            stringEmployee.Things = new List<string> { "Laptop", "Chair", "Desk" };




            //Instantiate an Employee object with type “int” as its generic parameter.
            Employee<int> intEmployee = new Employee<int>();
            // Assign a list of integers as the property value of Things.
            intEmployee.Things = new List<int> { 1, 2, 3 };


            //Create a loop that prints all of the Things to the Console.
            Console.WriteLine("String Employee Things:");
            foreach (var thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("\nInteger Employee Things:");
            foreach (var thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }


}







