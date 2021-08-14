using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate 
            Employee emp = new Employee();
            // properties 
            emp.firstName = "Sample";
            emp.lastName = "Student";
            emp.SayName();
            emp.Quit();
        
        }
    }
}
