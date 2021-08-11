using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_sub
{
    public class MathOps
    {
        // data variables 
        public int X { get; set; }
        public int A { get; set; }
        public string Operator { get; set; }
      
        public MathOps()
        {

            // assign 
            X = 0;
            A = 1;
            Operator = "+";
            
        }
        // simple calculator for GetAnswer function
        public void GetAnswer()
        {   
            // variable objects for switch
            switch (Operator)
            {
                case "+":
                    int Answer = X + A;
                    Console.WriteLine(Answer);
                    break;
                case "-":
                    Answer = X - A;
                    Console.WriteLine(Answer);
                    break;
                case "/":
                    Answer = X / A;
                    Console.WriteLine(Answer);
                    break;
                case "*":
                    Answer = X * A;
                    Console.WriteLine(Answer);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            
        }

    }
}
