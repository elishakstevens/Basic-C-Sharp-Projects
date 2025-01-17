using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate first method of Operations class and display answer to console
            Operations addition = new Operations();
            addition = Operations.OperationOne(addition, 43);
            Console.WriteLine("The answer to {0} plus {1} equals {2}.", addition.Number, addition.Number, addition.Answer);
            Console.ReadLine();

            //Instantiate second method of Operations class and display answer to console
            Operations multiply = new Operations();
            multiply = Operations.OperationOne(multiply, 34.68);
            Console.WriteLine("The answer to {0} times {1} equals about {2}.", multiply.Decimal, multiply.Decimal, multiply.Answer);
            Console.ReadLine();

            //Instantiate third method of Operations class and display answer to console
            Operations divide = new Operations();
            divide = Operations.OperationOne(divide, "943");
            //Only display to console if method does not return null
            if (null != divide)
            {
                Console.WriteLine("The answer to {0} divided by 3 equals {1}.", divide.Number, divide.Answer);
                Console.ReadLine();
            }
        }
    }
}
