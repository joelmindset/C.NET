using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_sub
{
    class Program
    {
        static void Main(string[] args)
        {
            // constant
            const string greet = "Hello";
            // var type
            var ask = "How are you?";
            // create person
            Person person = new Person("Bob", "Ross");

            //  output person name and isHappy to user
            Console.WriteLine("{0}, {1} {2} {3} is {4}", greet, ask, person.fName, person.lName, person.isHappy);
            Console.WriteLine("Press enter to terminate program");
            Console.ReadLine();
        }

        
        public class Person
        {
            // Chain Constructor
            public Person(string fName, string lName) : this(fName,lName,"Good!")
            {

            }
            // Chain Constructor
            public Person(string afName, string alName, string aisHappy)
            {
                fName = afName;
                lName = alName;
                isHappy = aisHappy;
            }
            // getters and setters
            public string fName { get; set; }
            public string lName { get; set; }
            public string isHappy { get; set; } 

        }
    }
}
