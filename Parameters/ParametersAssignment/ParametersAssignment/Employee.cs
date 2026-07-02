using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersAssignment
{
    //deifne a generic class Employee with a generic type parameter T. Include a property Things of type List<T>.
    public class Employee<T>
    {
       
        public List<T> Things { get; set; }


    }
}
