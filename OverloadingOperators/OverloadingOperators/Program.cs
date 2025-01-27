using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate two Employee objects
            Employee employeeOne = new Employee() { Id = 123, FirstName = "Elisha", LastName = "Stevens" };
            Employee employeeTwo = new Employee() { Id = 123, FirstName = "Elijah", LastName = "Stevens"};

            //Full Name variables to make things easier
            string NameOne = employeeOne.FirstName + " " + employeeOne.LastName;
            string NameTwo = employeeTwo.FirstName + " " + employeeTwo.LastName;

            //Comparing both objects and displaying a message on the console
            if (employeeOne == employeeTwo)
            {
                Console.WriteLine("{0} and {1} have the same ID.", NameOne, NameTwo);
            }
            else if (employeeOne != employeeTwo)
            {
                Console.WriteLine("{0} and {1} have different IDs.", NameOne, NameTwo);
            }

            Console.ReadLine();
        }
    }
}
