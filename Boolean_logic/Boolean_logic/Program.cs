using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Qualifications");
            Console.Write("What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
            // create boolean for DUI
            Console.Write("have you ever had a DUI?: ");
            string dui = Console.ReadLine();
            dui = dui.ToLower();
            bool hasDUI = false;
            if (dui == "yes")
            {
                hasDUI = false;
            } else if (dui == "no")
            {
                hasDUI = true;
            } else
            {
                Console.WriteLine("Please answer \"yes\" or \"no\".");
            }
            Console.WriteLine(!hasDUI);
            Console.Write("How many speeding thickets do you have?: ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(tickets);
            Console.Write("Qualified?: ");
            // booleans for if applicant is qualified
            bool isAge = true;
            bool ticketCap = true;
            bool qualified = true;
            if (age > 15)
            {
                isAge = true;
            } else
            {
                isAge = false;
            }
            if (tickets < 3)
            {
                ticketCap = true;
            } else
            {
                ticketCap = false;
            }

            if (isAge && ticketCap && hasDUI)
            {
                qualified = true;
            } else if (!isAge || !hasDUI || !ticketCap)
            {
               qualified = false;
            } else
            {
                Console.WriteLine("Entered invalid response please try again.");
               
            }
            Console.WriteLine(qualified);
            Console.Read();
        }
    }
}
