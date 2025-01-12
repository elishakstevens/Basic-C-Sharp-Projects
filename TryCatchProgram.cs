using System;
using System.Collections.Generic;
using System.Linq.Expressions;

internal class Program
{
    static void Main(string[] args)
    {
        //Code to try with no errors
        try
        {
            //Create new list of integars
            List<int> numDivide = new List<int>()
            {
                18,
                14,
                35,
                26,
                94,
                76,
                37,
                21,
                10
            };

            //Prompt user to pick number - convert and save input
            Console.WriteLine("Pick a number to divide a list of numbers by: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Iterate through list, dividing each number by the input number
            // Display results for each on the console
            for (int i = 0; i < numDivide.Count; i++)
            {
                int answer = numDivide[i] / num;
                Console.WriteLine("\n" + numDivide[i] + " divided by " + num + " equals " + answer);
            }
        }
        // Dividing by zero error - if user inputs 0
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by zero.");
        }
        // Format Error - if user types anything that's not an integar
        catch (FormatException ex)
        {
            Console.WriteLine("Please provide a whole number.");
        }
        // Catches any other errors and displays their messages
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        //Display message on console after everything is done - code will execute no matter the errors
        finally
        {
            Console.ReadLine();
            Console.WriteLine("This code has emerged from a try/catch block and has continued on with program execution.");
            Console.ReadLine();
        }
    }
}
