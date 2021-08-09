 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_sub1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStringArray = { "Bob", "Steve", "Tyler" };
            Console.WriteLine("What would you like to add to the strings?");
            string addStringArray = Console.ReadLine();
            for (int i = 0; i < myStringArray.Length; i++)
            {
                myStringArray[i] = myStringArray[i] + " " + addStringArray;
            }
            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(myStringArray[i]);
            }
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("nice!");
            }
            List<string> colors = new List<string> { "blue", "green", "blue", "red", "yellow" };
            Console.WriteLine("Search a color to see if its in the list?");
            bool answer = false;
            int counter = 0;
            while (!answer)
            {

                string userColor = Console.ReadLine();
                foreach (string color in colors)
                {
 
                    if (color == userColor)
                    {
                        counter = counter + 1;
                        Console.WriteLine("You found: " + counter + " many times.");
                    }
                    if (color == userColor && counter <= colors.Count - 1)
                    {
                        answer = true;
                    }                        
                    if (color != userColor)
                    {
                        Console.WriteLine("color is " + color);
                    }
                }
                if (!answer)
                {
                    Console.WriteLine("Lets try again...");
                }
                

            }
            Console.Read();
        }
    }
}
