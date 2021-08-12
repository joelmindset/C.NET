using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSub
{
    public class MathMethod
    {
        
        // function for Integer | user input for math1.
        // math2 default = int 2
        public int MathInt(int math1, int math2 = 2)
        {
            // times numbers
            return math1 * math2;
        }
        // function for decimal | user input for mathDec1
        // mathDec2 default = decimal 2
        public int MathDecimal(decimal mathDec1, decimal mathDec2 = 2)
        {
            // times decimals then convert to int store in answer
            int answer = Convert.ToInt32(mathDec1 * mathDec2);
            //return answer to user
            return answer;
        }
        // function for string | user input for mathString
        // math2 default = int 2
        public int MathString(string mathString, int math2 = 2)
        {
            // try catch for int and string converter
            try
            {
                // convert string to int 
                int stringConvertInt = Convert.ToInt32(mathString);
                // times our numbers store in answer
                int answer = stringConvertInt * math2;
                // return answer to user
                return answer;
            }
            catch (Exception err)
            {
                int answer = 0;
                // show error to user
                Console.WriteLine(err.Message);
                return answer;
            }
        }
    }
}
