using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_sub
{
    class Program
    {
        static void Main(string[] args)
        {
            // list for employees 
            List<Employee> LstEmp = new List<Employee>();
            // list for joes for foreach loop
            List<Joes> joes = new List<Joes>();

            // add employees to list
            LstEmp.Add(new Employee("Jes", "Smith", 1));
            LstEmp.Add(new Employee("Rachel", "Reep", 2));
            LstEmp.Add(new Employee("Joe", "Joehanson", 3));
            LstEmp.Add(new Employee("Casey", "Black", 4));
            LstEmp.Add(new Employee("Keira", "Hanson", 5));
            LstEmp.Add(new Employee("Jessica", "Smith", 6));
            LstEmp.Add(new Employee("Jeremy", "Johnson", 7));
            LstEmp.Add(new Employee("Abe", "Lincoln", 8));
            LstEmp.Add(new Employee("Joe", "Dirt", 9));
            LstEmp.Add(new Employee("Bob", "Ross", 10));

            // foreach loop with fName "Joe"
            foreach(var i in LstEmp)
            {

                if(i.fName == "Joe")
                {
                    
                    joes.Add(new Joes(i.fName, i.lName, i.empID));
                    
                    
                }
            }
            // all that other code i typed just for the foreach loop fight in this one line Lambda
            List<Employee> newList = LstEmp.Where(x => x.fName == "Joe").ToList();

            // List joes in newList
            foreach(Employee employee in newList)
            {

                Console.WriteLine("{0} {1} {2}", employee.fName, employee.lName, employee.empID);
            }

            // Lambda for employees with empID > 5
            List<Employee> idgreaterFive = LstEmp.Where(x => x.empID > 5).ToList();

            foreach (Employee employee in idgreaterFive)
            {
                Console.WriteLine("{0} {1} {2}", employee.fName, employee.lName, employee.empID);
            }


            Console.Read();
        }
        public class Joes
        {   
            // variables for Joes
            public string fName { set; get; }
            public string lName { set; get; }
            public int empID { set; get; }
            // constructor
            public Joes(string afName, string alName, int aEmpID)
            {
                fName = afName;
                lName = alName;
                empID = aEmpID;

            }
        }
        public class Employee
        {
            // variables for Employee
            public string fName { set; get; }
            public string lName { set; get; }
            public int empID { set; get; }
            // constructor
            public Employee(string afName, string alName, int aEmpID)
            {
                fName = afName;
                lName = alName;
                empID = aEmpID;

            }
        }    
    }
}
