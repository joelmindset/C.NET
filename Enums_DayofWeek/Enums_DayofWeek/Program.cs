using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user 
            Console.WriteLine("What day of the week is it? Please enter with the first letter capitalized.");
            // object user input
            string userDay = Console.ReadLine();
            
            DayOfWeek day;
            // switch for user input of day of week
            try
            {   
                // parse enum for the day
                day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userDay);
                switch (day)
                {
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Sunday it is!");
                        break;
                    case DayOfWeek.Monday:
                        Console.WriteLine("Monday it is!");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("Tuesday it is!");
                        break;
                    case DayOfWeek.Wednesday:
                        Console.WriteLine("Wednesday it is!");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("Thursday it is!");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("Friday it is!");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Saturday it is!");
                        break;
                }

            }
            // if user input wrong return error
            catch (Exception ex)
            {
                Console.WriteLine("sorry please enter a day of the week with the first letter capitalized. example: \"Tuesday\"");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
