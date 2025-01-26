using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSubAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Employee: {0} {1}", firstName, lastName);
        }
    }
}
