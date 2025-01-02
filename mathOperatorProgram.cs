using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multiplying 50 to user's provided number and displaying to console
            Console.WriteLine("Provide a number:");
            string num = Console.ReadLine();
            int newNum = Int32.Parse(num);
            int multiply = newNum * 50;
            Console.WriteLine(num + " times 50 = " + multiply.ToString());
            Console.ReadLine();

            // Adding 25 to user's provided number and displaying to console
            Console.WriteLine("Provide a new number:");
            string numTwo = Console.ReadLine();
            int newNumTwo = Int32.Parse(numTwo);
            int addition = newNumTwo + 25;
            Console.WriteLine(numTwo + " plus 25 = " + addition.ToString());
            Console.ReadLine();

            // Dividing user's provided number by 12.5 and displaying to console
            Console.WriteLine("Provide a new number:");
            string numThree = Console.ReadLine();
            int newNumThree = Int32.Parse(numThree);
            double division = newNumThree / 12.5;
            Console.WriteLine(numThree + " divided by 12.5 = " + division.ToString());
            Console.ReadLine();

            // Comparing user's provided number to 50 to see if it's greater and displaying true/false to console
            Console.WriteLine("Provide a new number:");
            string numFour = Console.ReadLine();
            int newNumFour = Int32.Parse(numFour);
            bool greaterThan = newNumFour > 50;
            Console.WriteLine("Is " + numFour + " greater than 50? " + greaterThan.ToString());
            Console.ReadLine();

            // Dividing user's provided number by 7 and displaying remainder to console
            Console.WriteLine("Provide a new number:");
            string numFive = Console.ReadLine();
            int newNumFive = Int32.Parse(numFive);
            int remainder = newNumFive % 7;
            Console.WriteLine("The remainder of " + numFive + " divided by 7 is " + remainder.ToString());
            Console.ReadLine();

            
        }
    }
}
