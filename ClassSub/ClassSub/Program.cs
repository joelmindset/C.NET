using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSub
{
    class Program
    {
        static void Main(string[] args)
        {
            MathTool tool = new MathTool();
            // user input for divide by 2 method Div2
            Console.WriteLine("What number would you like to divide by 2?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            tool.Div2(num1);
            int a = 50;
            // outmethod for overload method
            int b = MathTool.OutMethod(out a);
            Console.WriteLine("Overload method: {0}", b);
            Console.WriteLine("Press enter to terminate program...");
            Console.ReadLine();
        }
    }
}
