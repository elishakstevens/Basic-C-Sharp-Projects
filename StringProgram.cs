using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining three strings
            string strOne = "This string is ";
            string strTwo = "going to be ";
            string strThree = "concatenated together.";
            // Concatenating strings together and displaying on console
            Console.WriteLine(strOne + strTwo + strThree);
            Console.ReadLine();

            // Changing lower case string to uppercase and displaying on console
            string upperCase = "this string is going to be uppercase.";
            Console.WriteLine(upperCase.ToUpper());
            Console.ReadLine();

            // Creating a string object
            StringBuilder paragraph = new StringBuilder();
            //Adding to the object one sentence at a time
            paragraph.Append("This is sentence #1. ");
            paragraph.Append("This is sentence #2. ");
            paragraph.Append("This is sentence #3. ");
            paragraph.Append("This is the last sentence.");
            // Displays object as one string
            Console.WriteLine(paragraph.ToString());
            Console.ReadLine();


        }
    }
}
