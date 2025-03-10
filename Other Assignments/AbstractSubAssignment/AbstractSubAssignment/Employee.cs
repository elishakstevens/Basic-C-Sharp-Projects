using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSubAssignment
{
    //Inherit from Base Class
    public class Employee : Person
    {
        //Define method from Base Class
        public override void SayName()
        {
            Console.WriteLine("Employee: {0} {1}", firstName, lastName);
        }
    }
}
