using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassNew
{
    internal class Program
    {
        static void Operation(int num1, int num2)
        {
            int num3 = (num1 * 3) % 6;
            Console.WriteLine("Second Integar: " + num2);
            Console.ReadLine();
            Console.WriteLine("Answer to Operation on First Integar: " + num3);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Instantiate Class
            var operation = new Program();
            //Call method, passing in two numbers
            Operation(45, 31);
            //Call method, specifying parameters by name
            Operation(num1: 92, num2: 94);
        }
    }
}
