using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Calculator
    {
        // The second parameter 'number2' is optional and defaults to 10 if not provided
        public int AddNumbers(int number1, int number2 = 10)
        {
            int result = number1 + number2;
            return result;
        }
    }
}
