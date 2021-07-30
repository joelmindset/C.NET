using System;


namespace DailyReportSub
{
    class Program
    {
        static void Main()
        {
            //intro and first quiestion
            Console.WriteLine(" The Tech Academy \r \n Stundent Daily Report \r \n What is your Name?:");
            string userName = Console.ReadLine();
            Console.WriteLine("What course are you on?:");
            string userCourse = Console.ReadLine();
            Console.WriteLine("What is your Current page number?:");
            string userPageNum = Console.ReadLine();
            // Convert input string data (userPageNum) to int (pageNumber)
            int pageNumber = Convert.ToInt32(userPageNum);
            Console.WriteLine("Do you need help with anything? Please only answer with \"true\" or \"false\":");
            string userhelp = Console.ReadLine();
            // convert input to boolean
            bool needshelp = Convert.ToBoolean(userhelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? please give specifics:");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific:");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?:");
            string userHours = Console.ReadLine();
            // convert string input to int
            int hoursStudied = Convert.ToInt32(userHours);
            // exit and goodbye
            Console.WriteLine("Thank you for your answers. An instructor will resond to this shortly. Have a great day! \n This is the end of Program.");
            Console.Read();
        }
    }
}
