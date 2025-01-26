using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSubAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Class
            Employee employee = new Employee() {firstName = "Sample", lastName = "Student"};
            //Call method from instantiated class
            employee.SayName();
            Console.ReadLine();

        }
    }
}
