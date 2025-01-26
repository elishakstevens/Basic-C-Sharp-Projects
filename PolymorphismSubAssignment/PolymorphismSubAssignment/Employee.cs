using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubAssignment
{
    //Inherit from Base Class and Interface
    public class Employee : Person, IQuittable
    {
        //Define method from Base Class
        public override void SayName()
        {
            Console.WriteLine("Employee: {0} {1}", firstName, lastName);
        }

        //Define method from Interface
        public void Quit()
        {
            Console.WriteLine("Has {0} {1} Quit? Y/N\n", firstName, lastName);
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                Console.WriteLine("{0} {1} is no longer employed with us.", firstName, lastName);
            }
            else if (answer == "N")
            {
                Console.WriteLine("{0} {1} is currently employed with us.", firstName, lastName);
            }
        }
    }
}
