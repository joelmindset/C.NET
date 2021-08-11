using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_sub
{
    class Program
    {
        static void Main(string[] args)
        {
            // mathOps call
            MathOps mathOps = new MathOps();
            // user input number in mathOps.A
            Console.WriteLine("What is the first number?");
            mathOps.A = Convert.ToInt32(Console.ReadLine());
            // user input number in mathOps.Operator
            Console.WriteLine("What operator would you like to use?");
            mathOps.Operator = Convert.ToString(Console.ReadLine());
            // user input number in mathOps.X
            Console.WriteLine("What is the second number?");
            mathOps.X = Convert.ToInt32(Console.ReadLine());
            
            // call GetAnswer function
            mathOps.GetAnswer();
            Console.ReadLine();
            
        }
    }
}
