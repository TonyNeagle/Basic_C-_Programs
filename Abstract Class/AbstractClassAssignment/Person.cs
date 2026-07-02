using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{


    // Create an abstract class called Person 

    public abstract class Person


    {
        // create two properties of type string called FirstName and LastName
        // give it the method SayName

        public string FirstName { get; set; } // auto-implemented property for FirstName
        public string LastName { get; set; } // auto-implemented property for LastName

        public abstract void SayName(); // abstract method that must be implemented by derived classes

    }
}
