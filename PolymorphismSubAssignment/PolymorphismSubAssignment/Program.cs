using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate class
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            //Call method from Person class
            employee.SayName();
            Console.ReadLine();

            //Call method from interface
            employee.Quit();
            Console.ReadLine();

            //Create new object through type IQuittable
            //Polymorphism - changed parameter values
            //Called method from interface
            IQuittable employee2 = new Employee() { firstName = "Elisha", lastName = "Stevens" };
            employee2.Quit();
            Console.ReadLine();
        }
    }
}
