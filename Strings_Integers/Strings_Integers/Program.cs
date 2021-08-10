using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch block for numberList divided by user input
            try
            {
                // number list
                List<int> numberList = new List<int> { 4, 24, 26, 48 };
                // user input number for userDivide
                Console.WriteLine("what would you like to divide your list by?");
                int userDivide = Convert.ToInt32(Console.ReadLine());
                foreach (int i in numberList)
                {
                    // loop threw each item in numberList and divide by userDivide
                    int result = i / userDivide;
                    // present result to user
                    Console.WriteLine(result);
                }
            }
            // user input string error
            catch (FormatException)
            {
                Console.WriteLine("please only enter a number.");
            }
            // user input 0 error
            catch (DivideByZeroException)
            {
                Console.WriteLine("cant divide by zero enter a whole number.");
            }
            // user other errors
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // exit program
            finally
            {
                Console.WriteLine("finished with program.");
                Console.ReadLine();
            }
                       
        }
    }
}
