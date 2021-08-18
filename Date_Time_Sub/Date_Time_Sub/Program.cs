using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            // set a variable to the current time
            DateTime currentTime = DateTime.Now;
            // output current time to user
            Console.WriteLine("The current date and time is {0}", currentTime);
            // ask user hours
            Console.WriteLine("Enter a number of hours you want to be displayed from current time");
            // variable for user hours 
            int userHours = Convert.ToInt32(Console.ReadLine());
            // add user hours to currentTime and give it to hoursfromNow
            DateTime hoursfromNow = currentTime.AddHours(userHours);
            // present user with there hours picked and what time and date it will be for hoursfromNOW
            Console.WriteLine("\n\nIn {0} hours it will be {1}.", userHours, hoursfromNow);
            // EXIT
            Console.WriteLine("Press enter to terminate program.");
            Console.ReadLine();
        }
    }
}
