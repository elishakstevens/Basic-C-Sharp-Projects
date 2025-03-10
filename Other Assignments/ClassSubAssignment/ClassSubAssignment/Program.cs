using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Class
            var random = new randomOp();

            //Have user provide number, convert to integer, and input into method
            Console.WriteLine("Please enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            random.NumOp(userNum, out _);

            //Have user provide word and input into method
            Console.WriteLine("Please provide a random word: ");
            string str1 = Console.ReadLine();
            random.StrOp(str1, out _);

            //Have user pick a number and input into method
            Console.WriteLine("On a scale of 1 to 10, how do you feel? (You can use decimals.)");
            double userDoub = Convert.ToDouble(Console.ReadLine());
            random.StrOp(userDoub, out _);
        }
    }
}
