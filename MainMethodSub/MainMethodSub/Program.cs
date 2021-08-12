using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSub
{
    class Program
    {
        static void Main(string[] args)
        {
            // call for class
            MathMethod getMath = new MathMethod();
            Console.WriteLine("Please enter a number: ");
            // input from user
            int userInt = Convert.ToInt32(Console.ReadLine());
            // call MathInt method
            Console.WriteLine(getMath.MathInt(userInt));
            Console.WriteLine("Please enter a number or decimal. Number will be rounded: ");
            // input from user
            decimal userDec = Convert.ToDecimal(Console.ReadLine());
            // call MathDecimal method returns int
            Console.WriteLine(getMath.MathDecimal(userDec));
            Console.WriteLine("Please enter a number: ");
            // input from user
            string userString = Console.ReadLine();
            // call MathString method returns int
            Console.WriteLine(getMath.MathString(userString));

            Console.ReadLine();
        }
    }
}
