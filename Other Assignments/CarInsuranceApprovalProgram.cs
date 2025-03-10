using System;

namespace CarInsuranceApprovalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instruction for Applicant
            Console.WriteLine("Please answer the following questions.");
            Console.ReadLine();

            // Ask for applicant's age to make sure they are over 15 years old
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int userAge = Int32.Parse(age);

            // Ask if applicant has ever had a DUI to make sure they've never had one
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool userDUI = bool.Parse(dui);

            // Ask if applicant has any speeding tickets to make sure they don't have more than 3
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedTickets = Int32.Parse(tickets);

            // Determining if applicant qualifies or not
            Console.WriteLine("Based on your answers, are you qualified?");
            Console.WriteLine(userAge > 15 && userDUI == false && speedTickets <= 3);
            Console.ReadLine();
            
        }
    }
}
