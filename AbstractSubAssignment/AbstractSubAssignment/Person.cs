using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSubAssignment
{
    public abstract class Person
    {
        //Properties of a Person
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Method of a Person to be defined by all inheriting classes
        public abstract void SayName();
    }
}
