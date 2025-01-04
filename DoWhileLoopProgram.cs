using System;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boolean Comparison using while loop
            int num = 0;
            while (num < 11)
            {
                Console.WriteLine("This is Loop Hit #" + num);
                Console.ReadLine();
                num++;
            }
            

            //Boolean Comparison using do while loop
            Console.WriteLine("I'm thinking of a number between 1-10. What is it?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool doNum = number >= 7;

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
            while (!doNum);

            Console.ReadLine();
        }
    }
}
