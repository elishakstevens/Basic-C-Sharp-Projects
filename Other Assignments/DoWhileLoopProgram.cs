using System;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize Counter to 0
            int counter = 0;
            // Set While loop to loop 11 times, from 0 to 10
            while (counter < 11)
            {
                // Format and Display each loop in console, then add 1 to counter
                Console.WriteLine("This is Loop Hit #" + counter);
                Console.ReadLine();
                counter++;
            }
            

            // Prompt user to guess a number within a range
            Console.WriteLine("I'm thinking of a number between 1-10. What is it?");
            int number = Convert.ToInt32(Console.ReadLine());
            // Set number user is trying to guess at 7
            bool doNum = number >= 7;

            // Hitting switch at least once no matter what the user guesses
            do
            {
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("That is not the number I'm thinking of...");
                        Console.WriteLine("Guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Correct! That is the number!");
                        doNum = true;
                        break;
                    default:
                        Console.WriteLine("Something went wrong...");
                        break;
                }
            }
            // Looping through switch statement if user guesses the wrong number until correct number is guessed
            while (!doNum);

            Console.ReadLine();
        }
    }
}
