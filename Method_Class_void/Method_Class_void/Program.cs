using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_void
{
    class Program
    {
        static void Main(string[] args)
        {
            // call variable 
            OperatVoid callOper = new OperatVoid();
            // user input assign to num1
            Console.WriteLine("Input a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            // user input assign to num2
            Console.WriteLine("Input another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // use num1 and num2 and plug into MethOper perimeters 
            Console.WriteLine("lets see the second integer.");
            callOper.MethodOper(num1, num2);
            Console.WriteLine("now lets not try {0} and {1} instead lets do 5 and 4", num1, num2);
            // plug 5 and 4 into MethOper perimeters
            callOper.MethodOper(5, 4);
            // Exit
            Console.WriteLine("Press enter to terminate program");
            Console.ReadLine();

        }
    }
}
