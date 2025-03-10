using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setting a constant variable that cannot be changed
            const string FoodType = "fruit";

            //Prompting user and saving response
            Console.WriteLine("What is your favorite {0}?", FoodType);
            string favFruit = Console.ReadLine().ToLower();

            //Returning text to user based on response
            Console.WriteLine("Your favorite {0} is {1}!", FoodType, favFruit);
            Console.ReadLine();

            //Promping user and saving reponse
            Console.WriteLine("How would you describe a {0} in one word?\n(Press enter to skip.)", favFruit);
            string fruitWord = Console.ReadLine().ToLower();

            //If user does not provide a descriptor, will provide default
            //If user does, will use what they provide
            if (fruitWord == "")
            {
                var fruit = new Fruit(favFruit);
            }
            else
            {
                var fruit = new Fruit(favFruit, fruitWord);
            }
            Console.ReadLine();
        }
    }
}
