﻿using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int winNum = rand.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number in between 0 and 100:");
                string s = Console.ReadLine();
                int userInput = int.Parse(s);

                if (userInput > winNum)
                {
                    Console.WriteLine("Too high! Guess lower...");
                }
                else if (userInput < winNum)
                {
                    Console.WriteLine("Too low! Guess higher...");
                }
                else if (userInput == winNum)
                {
                    Console.WriteLine("YOU WIN!!!");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
