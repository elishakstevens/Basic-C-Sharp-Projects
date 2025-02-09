using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Checking for valid answers - no negative or zero
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("How old are you?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer || age <= 0) throw new ArgumentException();
                }
                //Find the year that the person was born (not 100% accurate, should be more specific)
                int yearOfBirth = DateTime.Now.Year - age;
                //Display year that user was born
                Console.WriteLine("You were born in {0}.", yearOfBirth);
                Console.ReadLine();
            }
            //exception if user enters negative numbers, zero, or letters 
            catch (ArgumentException)
            {
                Console.WriteLine("I don't know about that...");
                Console.ReadLine();
                Console.WriteLine("Bye.");
                Console.ReadLine();
                return;
            }
            //Covers all other exceptions
            catch (Exception)
            {
                Console.WriteLine("An error has occurred. Please contact your system administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
