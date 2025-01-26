using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects
{
    internal class Person
    {
        //Class Properties
        //Define properties related to a person's name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Class Methods
        //Create a method that will display the name of a person on the console
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
