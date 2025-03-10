using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Operations
    {
        //Create class and set all properties to 0
        public Operations()
        {
            Number = 0;
            Decimal = 0.0;
            Answer = 0;
        }
        //Defining each property's data type
        public int Number { get; set; }
        public double Decimal { get; set; }
        public int Answer { get; set; }

        //First method of class, adding an integar to itself
        public static Operations OperationOne(Operations addition, int num)
        {
            addition.Number = num;
            addition.Decimal = 0;
            addition.Answer = num + num;
            return addition;
        }

        //Second method of class, multiplying a decimal number to itself and returning an integar
        public static Operations OperationOne(Operations multiply, double number)
        {
            double answer = number * number;
            int ansInt = Convert.ToInt32(answer);
            multiply.Number = 0;
            multiply.Decimal = number;
            multiply.Answer = ansInt;
            return multiply;
        }

        //Third method of class, converting number as a string to an integar and dividing by 3
        //If string provided is not a number, give error message, return null and close program
        public static Operations OperationOne(Operations divide, string divideNum)
        {
            bool numBool = int.TryParse(divideNum, out _);
            if (!numBool)
            {
                Console.WriteLine("Error detected. Goodbye.");
                Console.ReadLine();
            }
            else if (numBool)
            {
                int divideNumber = Convert.ToInt32(divideNum);
                divide.Decimal = 0;
                divide.Number = divideNumber;
                divide.Answer = divideNumber/3;
                return divide;
            }
            return null;
        }

    }
}
