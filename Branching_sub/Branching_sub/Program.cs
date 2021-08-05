using System;


namespace Branching_sub
{
    class Program
    {
        // program for shipping cost for costumer 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            // Objects for box and shipping costs
            double weight = Convert.ToDouble(Console.ReadLine());
            double width = 0;
            double height = 0;
            double length = 0;
            double dimension = 0;
            double dimensionTotal = 0;
            decimal estimate = 0.00m;
            // under 50 weight get dimension / over weight exit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            } else
            {
                Console.WriteLine("Please enter the package width:");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                length = Convert.ToDouble(Console.ReadLine());
                dimension = length * height * width;
                dimensionTotal = length + height + width;


            }
            // under 50 dimensions get estimate and present to user / over dimensions  exit
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
            } else
            {
                estimate = Convert.ToDecimal(dimension * weight / 100.00) + 0.00m;
                Console.WriteLine("Your estimated total for shipping this package is: $" + estimate);
                Console.WriteLine("Thank you!");
                Console.Read();
            }
        }
    }
}
