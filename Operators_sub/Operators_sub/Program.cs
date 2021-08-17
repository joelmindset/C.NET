using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_sub
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { empID = 1, FirstName = "Jesse", LastName = "Johnson" };
            Employee emp2 = new Employee() { empID = 2, FirstName = "Rob", LastName = "Smith" };

            Console.WriteLine(emp1 == emp2);
                      
            Console.ReadLine();
        }
    }
}
