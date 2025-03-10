using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsNew
{
    internal class Program
    {
        //First method of class, adding two integars together
        static int Operation(int num1, int num2)
        {
            return num1 + num2;
        }

        //Second method of class, multiplying two decimal number together
        static double Operation(double num1, double num2)
        {
            return num1 * num2;
        }

        //Third method of class, converting two string numbers into integars and dividing them
        static int Operation(string num1, string num2)
        {
            int num3 = 0;
            try
            {
                int numInt1 = Convert.ToInt32(num1);
                int numInt2 = Convert.ToInt32(num2);
                num3 = numInt1 / numInt2;
            }
            catch
            {
                Console.WriteLine("Error detected. Goodbye.");
                Console.ReadLine();
            }
            return num3;
        }

        static void Main(string[] args)
        {
            //Instantiate first Operation Method and display answer to console
            var operationAdd = new Program();
            int addition = Operation(65, 43);
            Console.WriteLine("The answer to operation #1 is " + addition);
            Console.ReadLine();

            //Instantiate second Operation Method and display to console
            var operationMul = new Program();
            double multiply = Operation(63.58, 34.68);
            Console.WriteLine("The answer to operation #2 is " + multiply);
            Console.ReadLine();

            //Instantiate third Operation method and display to console
            //If either parameter is not able to convert to an integar,
            //  an error message with display on console instead
            var operationDiv = new Program();
            int divide = Operation("9", "3");
            if (divide != 0)
            {
                Console.WriteLine("The answer to operation #3 is " + divide);
                Console.ReadLine();
            }
        }
    }
}
