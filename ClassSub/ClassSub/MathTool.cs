using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSub
{
    public class MathTool
    {
        public void Div2( int num1)
        {
            // user input divide by 2
           int answer = num1 / 2;
            Console.WriteLine(answer);            
        }
        public static int OutMethod(out int num1)
        {
            // overload method
            int X = 15;
            num1 = X;
            return num1;
        }
    }
}
