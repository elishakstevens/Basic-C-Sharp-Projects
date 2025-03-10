using System;
using System.Collections.Generic;


internal class Program
{
    static void Main(string[] args)
    {
        //Array of Strings
        string[] stringArr = { "Mary", "Billy", "Spencer", "Shane", "Alex" };
        //Ask user to choose a number for a name and convert answer to integar
        Console.WriteLine("Please select a number from 1-5 to choose a name:");
        int indexNum = Convert.ToInt32(Console.ReadLine());

        //Provide name if user provides the correct number
        if (indexNum >= 1 && indexNum <= 5)
        {
            Console.WriteLine(stringArr[indexNum - 1]);
        }
        //Give error message if user does provide a number from 1-5
        else
        {
            Console.WriteLine("Index " + indexNum + " does not exist.");
        }
        Console.ReadLine();


        //Array of Integars
        int[] intArr = { 3, 9, 14, 22, 34 };
        //Ask user to choose number for another number and convert answer to integar
        Console.WriteLine("Please select a number from 1-5 for another number:");
        int indNum = Convert.ToInt32(Console.ReadLine());

        //Provide number if user provides correct index number
        if (indNum >= 1 && indNum <= 5)
        {
            Console.WriteLine(intArr[indNum - 1]);
        }
        //Give error message if user does not provide correct index number
        else
        {
            Console.WriteLine("Index " + indNum + " does not exist.");
        }
        Console.ReadLine();


        //List of Strings
        List<string> strList = new List<string>()
                                {
                                    "Apple",
                                    "Banana",
                                    "Mango",
                                    "Pineapple",
                                    "Watermelon"
                                };
        //Ask user to provide a number fo a fruit and convert answer to integar
        Console.WriteLine("Please select a number from 1-5 for a fruit:");
        int indexFruit = Convert.ToInt32(Console.ReadLine());

        //Provide fruit if user gives correct index number
        if (indexFruit >=1 && indexFruit <= 5)
        {
            Console.WriteLine(strList[indexFruit - 1]);
        }
        //Give an error message if user does not provide correct index number
        else
        {
            Console.WriteLine("Index " + indexFruit + " does not exist.");
        }
        Console.ReadLine();
    }
}
