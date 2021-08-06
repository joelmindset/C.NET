using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// arrays loops and if 
namespace ConsoleAppArraySub
{
    class Program
    {
        static void Main(string[] args)
        {
            // string array
            string[] stringArray = { "Go around but hes following you.", "You fight and win.", "Give up the loot and head back.", "You jump over him try to run, but trip on a rock, all is lost." };
            Console.WriteLine("You're on your way down a forest road, a thief stops you asking for your loot.");
            Console.Write("Answer 0-3 to see what happens next: ");

            int userAnswer = 4;
            int maxInt = 4;
            // loop for asking the a number > 4
            while (userAnswer >= maxInt)
            {
                userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer > 3)
                {
                    Console.WriteLine("Invalid entry, please enter 0-3 number again.");      
                }
            }
            if (userAnswer <= 3)
            {
                Console.WriteLine(stringArray[userAnswer]);
            }
            // number array
            int[] numberArray = { 7, 55, 96, 15, 82, 38 };
            Console.WriteLine("I'm think of 6 cards with different numbers can you pick my favorite number 15? Please only pick 0-5 for the 6 cards.");
            int numberGuess = Convert.ToInt32(Console.ReadLine());
            int currectGuess = 3;
            // if statements
            if(numberGuess != currectGuess || numberGuess < 6)
            {
                // loop for incorrect guess
                while (numberGuess != currectGuess)
                {
                    if (numberGuess > 5)
                    {
                        Console.WriteLine("Invalid entry, please only enter a number 0 to 5.");
                    }
                    Console.Write("You guessed: ");
                    Console.Write(numberArray[numberGuess]);
                    Console.WriteLine(". Please guess again...");
                    numberGuess = Convert.ToInt32(Console.ReadLine());
                }  
            }
            // correct guess
            if(numberGuess == currectGuess)
            {
                Console.Write("You guessed: ");
                Console.Write(numberArray[numberGuess]);
                Console.WriteLine(". You guessed the right card! Congrats you win!");
            }
            Console.Read();
            
        }
    }
}

