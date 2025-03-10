using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    public class Employee
    {
        //Properties of Class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overloading '==' operator
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            return (employeeOne.Id == employeeTwo.Id);
        }

        //Overloading '!=' operator
        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            return (employeeOne.Id != employeeTwo.Id);
        }
     }
}
