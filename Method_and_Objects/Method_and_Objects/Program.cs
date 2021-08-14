using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // object initialization and inheritance
            Employee EmpPerson = new Employee();
            // using employee and super persons
            EmpPerson.FirstName = "Sample";
            EmpPerson.LastName = "Student";
            EmpPerson.SayName(EmpPerson.FirstName, EmpPerson.LastName);
            Console.ReadLine();
        }
    }
}
