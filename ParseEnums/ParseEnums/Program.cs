using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParseEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try/catch block
            try
            {
                //Instantiate enum
                DaysOfTheWeek day = new DaysOfTheWeek();

                //Prompt user and save in variable
                Console.WriteLine("What is the current day of the week?");
                string currentDay = Console.ReadLine();

                //Parse through enum to match user answer to one of enum items
                bool enumDay = Enum.TryParse<DaysOfTheWeek>(currentDay, out DaysOfTheWeek today);
                
                //Display different messages if parse is true or fase
                if (!enumDay)
                {
                    Console.WriteLine($"{currentDay}? That's not a day of the week!");
                }
                else
                {
                    Console.WriteLine($"Today is {today}!");
                }
            }
            //Catch any errors and display message if do
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            //Program ends with this no matter what happens
            finally
            {
                Console.ReadLine();
            }
        }
        
        //enum of all the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
