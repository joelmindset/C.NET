using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_and_Objects
{
    public class Person
    {
        // create objects
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // present full name to console
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }        
}
