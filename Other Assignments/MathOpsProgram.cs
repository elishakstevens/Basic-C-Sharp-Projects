using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOpsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for a number and save that number
            Console.WriteLine("What number do you want to do math operations on?");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Instantiating class w/ user input
            Operations operations = new Operations();

            //adding user input 
            int answerAdd = operations.Add(userNum);
            Console.WriteLine(userNum + " plus 15 equals " + answerAdd);
            Console.ReadLine();

            //multiplying user input
            int answerMul = operations.Multiply(userNum);
            Console.WriteLine(userNum + " times 15 equals " + answerMul);
            Console.ReadLine();

            //subtracting user input
            int answerSub = operations.Subtract(userNum);
            Console.WriteLine(userNum + " minus 15 equals " + answerSub);
            Console.ReadLine();
        }
    }
}
