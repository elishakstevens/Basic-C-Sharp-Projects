using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssignment
{
    internal class Program
    {
        //Static Class 

        //Create a void method that outputs an integer
        //Divide data passed to it by 2
        public static void NumOp(int num, out int num2)
        {
            num2 = num / 2;
            Console.WriteLine(num2);
            Console.ReadLine();
        }

        //Method with output parameter
        public static void StrOp(string str1, out string str2)
        {
            str2 = "Your random word is: " + str1;
            Console.WriteLine(str2);
            Console.ReadLine();
        }
        //Method with output parameter
        //Overloading method above
        public static void StrOp(double doub, out string doubStr)
        {
            doubStr = "On a scale between 1 to 10, you feel like a " + doub;
            Console.WriteLine(doubStr);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Instantiate Class
            var divide = new Program();

            //Have user provide number, convert to integer, and input into method
            Console.WriteLine("Please enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            NumOp(userNum, out _);

            //Have user provide word and input into method
            Console.WriteLine("Please provide a random word: ");
            string str1 = Console.ReadLine();
            StrOp(str1, out _);

            //Have user pick a number and input into method
            Console.WriteLine("On a scale of 1 to 10, how do you feel? (You can use decimals.)");
            double userDoub = Convert.ToDouble(Console.ReadLine());
            StrOp(userDoub, out _);
        }
    }
}
