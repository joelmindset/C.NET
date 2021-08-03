using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Comparison_Operator
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Get hourly rates and weekly hours from 2 people
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.Write("What is your hourly rate?: ");
            double p1Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(p1Rate);
            Console.Write("How many hours do you work a week?: ");
            double p1Hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(p1Hours);
            Console.WriteLine("Person 2");
            Console.Write("What is your hourly rate?: ");
            double p2Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(p2Rate);
            Console.Write("How many hours do you work a week?: ");
            double p2Hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(p2Hours);
            // caculate yearly income
            double weeksYear = 52.1429;
            double p1Annual = weeksYear * p1Hours * p1Rate;
            double p2Annual = weeksYear * p2Hours * p2Rate;
            Console.WriteLine("Annual salary of Person 1: " + p1Annual);
            Console.WriteLine("Annual salary of Person 2: " + p2Annual);
            // boolean for Person 1 being max income
            bool p1Max = true;
            if ( p1Annual > p2Annual)
            {
                p1Max = true;
            } else
            {
                p1Max = false;
            }
            Console.WriteLine("Does Person 1 make more money then Person 2?");
            Console.WriteLine(Convert.ToString(p1Max));            
            Console.Read();
        }
    }
}
