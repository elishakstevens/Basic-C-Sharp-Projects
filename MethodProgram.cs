using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Operations class
            Operations pemdas = new Operations();

            //Prompt user to provide a number
            Console.WriteLine("Please provide a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Prompt user to provide a second number, if they want
            Console.WriteLine("Please provide a second number:\nThis is optional. Press Enter to skip.");
            string optionalNum = Console.ReadLine();

            //If user does not provide a second number, use the pre-defined second number in the pemdas method
            //Display answer on the console
            if (string.IsNullOrEmpty(optionalNum))
            {
                pemdas = Operations.Operation(pemdas, userNum);
                Console.WriteLine("With the number you provided, the answer is {0}.", pemdas.Answer);
            }
            //If user does provide a second number, it will override the pre-defined number
            //Display answer on the console
            else
            {
                int userNumTwo = Convert.ToInt32(optionalNum);
                pemdas = Operations.Operation(pemdas, userNum, userNumTwo);
                Console.WriteLine("With the numbers you provided, the answer is {0}.", pemdas.Answer);
            }
            Console.ReadLine();
        }
    }
}
