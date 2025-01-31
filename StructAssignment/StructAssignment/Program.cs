using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate struct and assign amount to prop
            Number number = new Number();
            number.Amount = 46;

            //Display amount on console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
