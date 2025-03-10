using System;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main()
        {
            //Intro for Daily Report
            string report = "The Tech Academy\nStudent Daily Report";
            Console.WriteLine(report);
            Console.ReadLine();

            // Questions to ask user
            string name = "What is your name?";
            string course = "What course are you on?";
            string page = "What page number?";
            string help = "Do you need help with anything? Please answer \"true\" or \"false.\"";
            string positiveExp = "Were there any positive experiences you'd like to share? Please give specifics.";
            string feedback = "Is there any other feedback you'd like to provide? Please be specific.";
            string hours = "How many hours did you study today?";

            // Asking for name and saving answer as String
            Console.WriteLine(name);
            string yourName = Console.ReadLine();

            // Asking for course and saving answer as String
            Console.WriteLine(course);
            string courseName = Console.ReadLine();

            // Asking for page number of course and saving answer as Integar
            Console.WriteLine(page);
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            // Asking if user needs help and saving answer as Bool
            Console.WriteLine(help);
            string helpNeed = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(helpNeed);

            // Asking if user had positive experience and saving answer as String
            Console.WriteLine(positiveExp);
            string experience = Console.ReadLine();

            // Asking if user has feedback to provide and saving answer as String
            Console.WriteLine(feedback);
            string feedBack = Console.ReadLine();

            // Asking hours studied and saving answer as Integar
            Console.WriteLine(hours);
            string hoursStudy = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudy);

            // Final message when user done with questions
            string finalMsg = "\n\nThank you for your answers.\nAn instructor will respond to this shortly.\nHave a great day!";
            Console.WriteLine(finalMsg);
            Console.ReadLine();

        }
    }
}
