using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_sub
{   
    // inherit Person class first and last name create employee class
    public class Employee : Person
    {
        // instance variables
        public int empID { get; set; }


        // override == return boolean
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.empID == emp2.empID;
        }
        // override != return boolean
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.empID != emp2.empID;
        }

    }
}
