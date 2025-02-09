using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubAssignment
{
    public class Fruit
    {
        //Setting private properties that won't be needed
        private string name;
        private string descriptor;
        
        //Chaining two constructors if user does not provide descriptor
        public Fruit(string name) : this(name, "yummy")
        {
        }
        //Creating constructor
        public Fruit(string name, string descriptor)
        {
            this.name = name;
            this.descriptor = descriptor;
            Console.WriteLine("A {0} {1} is my favorite fruit too!", descriptor, name);
        }
    }
}
