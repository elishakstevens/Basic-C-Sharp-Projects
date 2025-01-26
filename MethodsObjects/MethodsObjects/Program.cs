using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize Employee Object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //Call method to display to console
            employee.SayName();
        }
    }
}
