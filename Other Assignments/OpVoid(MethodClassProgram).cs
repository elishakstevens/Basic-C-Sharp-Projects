using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    internal class OpVoid
    {
        //Create class and initialize properties to 0
        public OpVoid()
        {
            NumberOne = 0;
            NumberTwo = 0;
            Answer = 0;
        }

        //Define each property's data type
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public int Answer { get; set; }

        //Create method that will perform math operation on the first number and saves the second number
        //void method - does not return anything
        public void Operation(OpVoid operation, int numOne, int numTwo)
        {
            int answerNumOne = (numOne * 3) % 6;
            operation.NumberOne = numOne;
            operation.NumberTwo = numTwo;
            operation.Answer = answerNumOne;
        }
    }
}
