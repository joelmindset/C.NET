using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color?");
            string color = Console.ReadLine();
            bool guessColor = color == "green";

            while (!guessColor)
            {
                switch(color)
                {
                    case "green":
                        Console.WriteLine("You guess right!");
                        
                        break;
                    default:
                        Console.WriteLine("Guess again.....");
                        color = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("Lets guess another color.");
            string color2 = Console.ReadLine();
            do
                switch (color2)
                {
                    case "blue":
                        Console.WriteLine("You guess right! You've wont the game.");
                        guessColor = true;
                        
                        break;
                    default:
                        Console.WriteLine("Guess again.....");
                        color2 = Console.ReadLine();
                        break;
                }
            while (!guessColor);
            Console.ReadLine();
        }
        
    }
}
