using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssignment
{
    internal class randomOp
    {
        //Static Class

        //Create a void method that outputs an integer
        //Divide data passed to it by 2
        public void NumOp(int num, out int num2)
        {
            num2 = num / 2;
            Console.WriteLine(num2);
            Console.ReadLine();
        }

        //Method with output parameter
        public void StrOp(string str1, out string str2)
        {
            str2 = "Your random word is: " + str1;
            Console.WriteLine(str2);
            Console.ReadLine();
        }

        //Method with output parameter
        //Overloading method above
        public void StrOp(double doub, out string doubStr)
        {
            doubStr = "On a scale between 1 to 10, you feel like a " + doub;
            Console.WriteLine(doubStr);
            Console.ReadLine();
        }
    }
}
