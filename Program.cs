using System;

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


            } while (win == false);
        }
    }
}
