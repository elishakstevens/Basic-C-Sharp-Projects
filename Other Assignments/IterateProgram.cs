using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Web;
using System.Xml;

internal class Program
{
    static void Main(string[] args)
    {
        ////////////PART 1////////////////////

        //Creating array
        string[] choiceArr = { "Y - ", "N - ", "Y - ", "Y - ", "N - ", "Y - " };

        //Prompting user to answer question and saving
        Console.WriteLine("Yes or No? Type Y or N.");
        string userAnswer = Console.ReadLine();

        //Adding user answer to each item in choiceArr
        for (int i = 0; i < choiceArr.Length; i++)
        {
            string choiceComp = choiceArr[i] + userAnswer;
            choiceArr[i] = choiceComp;
        }

        //Displaying each new item on console
        foreach (string compare in choiceArr)
        {
            Console.WriteLine(compare);
        }
        Console.ReadLine();

        ////////////PART 2////////////////////

        //Infinite Loop - fixed by inputting a condition statement that was
        // limiting along with a counter
        int counter = 0;
        while (counter < 6)
        {
            Console.WriteLine("Infinite Loop Fixed");
            counter++;
        }
        Console.ReadLine();

        ////////////PART 3///////////////////////

        //Create integar array
        int[] iterateArr = { 50, 67, 90, 84, 27, 51, 38, 97 };

        //Loop with "<" operator - print array to console
        for (int i = 0; i < iterateArr.Length; i++)
        {
            Console.WriteLine(iterateArr[i]);
        }
        Console.ReadLine();

        //Loop with "<=" operator - print array to console
        int counter2 = 0;
        while (counter2 <= 7)
        {
            Console.WriteLine(iterateArr[counter2]);
            counter2++;
        }
        Console.ReadLine();

        ////////////PART 4///////////////////////

        //Array of strings - each item is unique
        string[] commonNames = {
            "ashley",
            "britney",
            "stephanie",
            "jennifer",
            "john",
            "jane",
            "gabriel",
            "amanda",
            "michelle",
            "daniel",
            "adam",
            "spencer",
            "shane",
            "david",
            "trevor"
        };

        //prompt user for their name and save input
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();

        //define counters
        int counterNo = 0;
        int index = 0;
        //loop through array 
        for (int i = 0; i < commonNames.Length; i++)
        {
            //add 1 to counterNo if input does not match one of the strings in the array
            if (commonNames[i] != userName.ToLower())
            {
                counterNo++;
            }
            //if input matches one of the array items, add value of i to index
            // and add 1 to counterYes
            else if (commonNames[i] == userName.ToLower())
            {
                index = index + i;
            }
        }
        //After loop, if counterNo does not match the length of the array,
        // display confirmation message with index number
        if (counterNo != commonNames.Length)
        {
            Console.WriteLine("Congrats, " + userName + ", you have a common name! It was found in index #" + index);
        }
        //If counter does equal array length, display sorry message
        else
        {
            Console.WriteLine("Sorry, you don't have a common name.");
        }
        Console.ReadLine();


        ////////////PART 5///////////////////////

        //Create new list of common pets
        List<string> commonPets = new List<string>() {
                                "dog",
                                "cat",
                                "bird",
                                "fish",
                                "turtle",
                                "ferret",
                                "dog"
                                };

        //prompt user to provide their generic pet and save input
        Console.WriteLine("I want to see if your pet is as common as other people's pets.");
        Console.WriteLine("What kind of pet do you have? Be as generic as possible (i.e. Dog, Cat, Fish).");
        string animal = Console.ReadLine();

        //Define counter
        int counterPet = 0;
        //Iterate through list to find all indices that match input
        //Display on console and add 1 to counterPet
        for (int i = 0; i < commonPets.Count; i++)
        {
            if (animal.ToLower() == commonPets[i])
            {
                Console.WriteLine($"{i}");
                counterPet++;
            }
        }

        //If counter is 0, sorry message will display on console
        //If counter is greater than 0, congrats message will display on console
        if (counterPet == 0)
        {
            Console.WriteLine("Sorry, " + animal + " is not on the common pets list.");
        }
        else if (counterPet > 0)
        {
            Console.WriteLine("Congrats! " + animal + " is on the list at the indices listed above.");

        }
        Console.ReadLine();

        ////////////PART 6///////////////////////

        //Create list of wild cats, repeating one
        List<string> wildCats = new List<string>() {
                                "lion",
                                "tiger",
                                "jaguar",
                                "cheetah",
                                "leopard",
                                "tiger",
                                "cougar",
                                "bobcat"
                                };
        
        //Create another list that will find all the duplicated in first list
        List<string> duplicates = wildCats.FindAll(cats => wildCats.IndexOf(cats) != wildCats.LastIndexOf(cats));
        //Define counter
        int catCounter = 1;
        //Iterate through first list, comparing it to second list
        foreach (string cat in wildCats)
        {
            int i = wildCats.IndexOf(cat);
            //item is unique if duplicate list has no items or the current item does not match any duplicate items
            if (duplicates.Count == 0 || !duplicates.Contains(cat))
            {
                Console.WriteLine(cat + " - this item is unique");
            }
            //will display first duplicate item on list as unique since no items before were the same
            else if (duplicates.Contains(cat) && catCounter == 1)
            {
                Console.WriteLine(cat + " - this item is unique");
                catCounter++;
            }
            //Any duplicate items on the list after the first one will say it is a duplicate
            else if (duplicates.Contains(cat) && catCounter >= 2)
            {
                Console.WriteLine(cat + " - this item is a duplicate");
            }
            Console.ReadLine();
        }
    }
}
