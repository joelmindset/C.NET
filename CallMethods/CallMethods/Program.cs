using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // mathOps call
           
            MathOperation mathOp = new MathOperation();
            // user input number in mathOps.A
            Console.WriteLine("What is the first number?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            // user input number in mathOps.Operator
            Console.WriteLine("What operator would you like to use?");
            string Operator = Convert.ToString(Console.ReadLine());
            // user input number in mathOps.X
            Console.WriteLine("What is the second number?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            // switch for Operator to call methods 
            switch (Operator)
            {
                case "+":
                    Console.WriteLine(mathOp.getAdd(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(mathOp.getMinus(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(mathOp.getDiv(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(mathOp.getMulti(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.ReadLine();
        }
    }
}
