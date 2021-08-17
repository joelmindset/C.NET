using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_sub
{
    public class Employee : Person
    {
        public int empID { get; set; }



        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.empID == emp2.empID;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.empID != emp2.empID;
        }

    }
}
