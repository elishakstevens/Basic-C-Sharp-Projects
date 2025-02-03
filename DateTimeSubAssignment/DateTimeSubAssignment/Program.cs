using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a DateTime object of the current date and time
            //Display current to console
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(DateTime.Now);

            //Prompt user to provide a number of hours
            //Convert and save number
            Console.WriteLine("\nPlease provide a number of hours: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            //Use AddHours method from DateTime to add hours provided by user to the current date and time
            //Instantiate a new DateTime Object of this new System.DateTime
            //Display number of hours and the new date and time to console
            DateTime newDateTime = dateTime.AddHours(hours);
            Console.WriteLine("\nIn {0} hours, it will be this date and time:\n{1}", hours, newDateTime);
            Console.ReadLine();   
        }
    }
}
