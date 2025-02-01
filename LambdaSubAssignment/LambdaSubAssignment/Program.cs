using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instatiating employee class by creating new list
            //Adding new employees to list
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Goldberg" },
                new Employee { Id = 2, FirstName = "Elisha", LastName = "Stevens" },
                new Employee { Id = 3, FirstName = "David", LastName = "Garcia" },
                new Employee { Id = 4, FirstName = "Bethany", LastName = "Woods" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 6, FirstName = "Anna", LastName = "Stein" },
                new Employee { Id = 7, FirstName = "Joe", LastName = "Henderson" },
                new Employee { Id = 8, FirstName = "Monica", LastName = "Chase" },
                new Employee { Id = 9, FirstName = "Amanda", LastName = "Hendrickson" },
                new Employee { Id = 10, FirstName = "Gabriel", LastName = "Lorca" },
            };

            //Creating new list to add to
            List<Employee> listJoe = new List<Employee>();

            ////Iterating through first list and adding to second
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        listJoe.Add(employee);
            //    }
            //}

            //Iterating through employees list and adding to listJoe
            //Displaying results to console
            Console.WriteLine("Employees with the first name \'Joe\':\n");
            employees.ForEach(e =>
            {
                if (e.FirstName == "Joe")
                {
                    listJoe.Add(e);
                    Console.WriteLine("ID#" + e.Id + ": " + e.FirstName + " " + e.LastName);
                }
            });
            Console.ReadLine();

            //Creating a third list
            List<Employee> employeeIds = new List<Employee>();
            Console.WriteLine("Employees with IDs greater than 5:\n");
            //Iterating through employees list and adding to employeeIds list
            //Displaying results to console
            employees.ForEach(e =>
            {
                if (e.Id > 5)
                {
                    employeeIds.Add(e);
                    Console.WriteLine("ID#" + e.Id + ": " + e.FirstName + " " + e.LastName);
                }
            });
            Console.ReadLine();
        }
    }
}
