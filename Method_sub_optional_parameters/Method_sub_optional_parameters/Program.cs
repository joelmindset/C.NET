using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_sub_optional_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // call for class
            OptionalMethod opMath = new OptionalMethod();
            Console.WriteLine("Please enter a number: ");
            // input from user
            int userInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number. This one is optional nothing is needed: ");
            // input from user            
            // try if user puts value for Int
            try
            {
                Console.WriteLine("lets multiply!");
                int userInt2 = Convert.ToInt32(Console.ReadLine());
                // call OptionalMethod class mathInt method
                Console.WriteLine(opMath.MathInt(userInt, userInt2));
            }
            // if user only puts first value in userInt
            catch (FormatException)
            {
                Console.WriteLine("Your second number was left blank or was not a number. Lets fill it in with a number 2 and multiply!");
                Console.WriteLine(opMath.MathInt(userInt));
            }
            Console.ReadLine();
        }
    }
}
