using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "potato";
            string guess = "";
            string hint = "The relates to gardening and food.  The thing grows underground as a sprout, " +
                        "and is usually brown when harvested.  If you do not cook/eat it soon enough, then it will " +
                        "grow sprouts.  What could it be?";

            Console.WriteLine("This is a guessing game.  You need to guess the correct word to stop the program");
            Console.WriteLine("If you are having trouble, then enter 'hint'.");
            Console.WriteLine();
            Console.WriteLine();

            while (guess != secretWord)
            {
                if (guess == "hint")
                {
                    Console.WriteLine(hint);
                    Console.WriteLine();
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine().ToLower();
                } else
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine().ToLower();
                }
            }

            Console.ReadLine();
        }
    }
}
