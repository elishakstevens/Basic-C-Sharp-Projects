using System;

namespace PackageShippingQuote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro to program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            //Prompting user to give package weight
            Console.WriteLine("Package Weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            //Weight cannot be higher than 50 - if so, exit program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.. Have a good day!");
            }
            
            //Continue if weight is less than 50
            else if (weight <= 50)
            {
                //Prompt user for package width and convert to integar
                Console.WriteLine("Package Width:");
                int width = Convert.ToInt32(Console.ReadLine());

                //Prompt user for package height and convert to integar
                Console.WriteLine("Package Height:");
                int height = Convert.ToInt32(Console.ReadLine());

                //Prompt user for package length and convert to integar
                Console.WriteLine("Package Length:");
                int length = Convert.ToInt32(Console.ReadLine());

                //Add package dimensions together
                int addDimensions = width + height + length;

                //Create a shipping price estimate and format as a dollar amount
                int quote = ((width * height * length) * weight) / 100;
                string quoteDollar = "$" + quote.ToString() + ".00";

                //Sum of dimensions cannot be higher than 50
                //If so, exit program
                //If not, provide user the shipping quote
                string tooBig = addDimensions > 50 ? "Package too big to be shipped via Package Express." : "Estimated Shipping Total: " + quoteDollar + "\nThank you!";
                Console.WriteLine(tooBig);
            }
            else
            {
                //If anything goes wrong, will exit program
                Console.WriteLine("Something has gone wrong...");
            }
            Console.ReadLine();
        }
    }
}
