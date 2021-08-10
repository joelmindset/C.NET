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
            // string array for names
            string[] myStringArray = { "Bob", "Steve", "Tyler" };
            // ask user what they would like to add
            Console.WriteLine("What would you like to add to the names?");
            // user input variable addStringArray
            string addStringArray = Console.ReadLine();
            // for loop length of myStringArray array
            for (int i = 0; i < myStringArray.Length; i++)
            {
                // add addStringArray to myStringArray
                myStringArray[i] = myStringArray[i] + " " + addStringArray;
            }
            // for loop length of myStringArray array
            for (int i = 0; i < myStringArray.Length; i++)
            {
                // print each "myStringArray + addStringArray" item in myStringArray
                Console.WriteLine(myStringArray[i]);
            }
            // loop "nice!" 2 times
            for (int i = 1; i <= 2; i++)
            {
                // write nice!
                Console.WriteLine("nice!");
            }
            // list for colors
            List<string> colors = new List<string> { "blue", "green", "blue", "red", "yellow" };
            // ask user what color they would like to search for
            Console.WriteLine("Search a color to see if its in the list?");
            // boolean for while loop
            bool answer = false;
            // counter for how many times the user's input equals an item in the list
            int counter = 0;
            // boolean loop until user inputs a color in the list 
            while (!answer)
            {
                // input users color
                string userColor = Console.ReadLine();

                // loop each item in list
                foreach (string color in colors)
                {
                    // if user input equals an item on the list 
                    if (color == userColor)
                    {
                        // counter add 1
                        counter = counter + 1;
                        // present counter count to user
                        Console.WriteLine("You found: " + counter + " many times.");
                    }
                    // if the user's input equals item and is finished with first if in list boolean exit
                    if (color == userColor)
                    {
                        // exit while boolean
                        answer = true;
                    }
                    // if list item does not equal users input then print item in list
                    if (color != userColor)
                    {

                        Console.WriteLine("color is " + color);
                    }
                }
                // if no answer re-while-loop
                if (!answer)
                {
                    Console.WriteLine("Lets try again...");
                }
            }
            // read so application doesn't terminate to fast.
            Console.Read();
        }
    }
}
