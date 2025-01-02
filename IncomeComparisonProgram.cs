using System;

namespace IncomeComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Title of Program
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // Person 1 hourly rate and hours worked per week
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string personOneRate = Console.ReadLine();
            int hourRateOne = Int32.Parse(personOneRate);
            Console.WriteLine("How many hours do you work per week?");
            string personOneHours = Console.ReadLine();
            int hourWeekOne = Int32.Parse(personOneHours);
            Console.WriteLine(" ");

            // Using user's input to find annual salary of Person 1
            // 52 weeks in 1 year
            int salaryOne = hourRateOne * hourWeekOne * 52;

            // Person 2 hourly rate and hours worked per week
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string personTwoRate = Console.ReadLine();
            int hourRateTwo = Int32.Parse(personTwoRate);
            Console.WriteLine("How many hours do you work per week?");
            string personTwoHours = Console.ReadLine();
            int hourWeekTwo = Int32.Parse(personTwoHours);
            Console.WriteLine(" ");

            // Using user's input to find annual salary of Person 2
            // 52 weeks in 1 year
            int salaryTwo = hourRateTwo * hourWeekTwo * 52;

            // Displaying Person 1's salary on console
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(salaryOne.ToString());
            Console.ReadLine();

            // Displaying Person 2's salary on console
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(salaryTwo.ToString());
            Console.ReadLine();

            // Comparing salaries of Person 1 and Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool salaryComparison = salaryOne > salaryTwo;
            Console.WriteLine(salaryComparison.ToString());
            Console.ReadLine();

        }
    }
}
