using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate OpVoid class
            OpVoid operation = new OpVoid();

            //Call method and display results to the console
            operation.Operation(operation, 45, 31);
            Console.WriteLine("\n\nOperation with first number: " + operation.Answer + "\n\nSecond Number: " + operation.NumberTwo + "\n");
            Console.ReadLine();

            //Call method, specifying parameters by name, and display results to the console
            operation.Operation(operation, numOne: 92, numTwo: 94);
            Console.WriteLine("\n\nOperation with first number: " + operation.Answer + "\n\nSecond Number: " + operation.NumberTwo + "\n");
            Console.ReadLine();
        }
    }
}
