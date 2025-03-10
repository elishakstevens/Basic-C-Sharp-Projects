using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Operations
    {
        //Create class and set properties to 0
        public Operations()
        {
            Number = 0;
            Answer = 0;
        }
        //Define each property's data types
        public int Number { get; set; }
        public int Answer { get; set; }

        //Create method for class where two numbers are used for a math operation and the answer is returned
        //The first number is required but the second number is optional
        public static Operations Operation(Operations pemdas, int number, int numTwo = 2)
        {
            int answer = ((number + numTwo * 7) / 2) - number;
            pemdas.Number = number;
            pemdas.Answer = answer;
            return pemdas;
        }
    }
}
