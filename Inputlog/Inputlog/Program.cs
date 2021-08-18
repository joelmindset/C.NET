using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inputlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            // using streamwriter on file location true = append to file and write num
            using (StreamWriter file = new StreamWriter(@"C:\Users\joelm\logs\log.txt", true))
            {
                file.WriteLine(num);
            }
        }
    }
}
