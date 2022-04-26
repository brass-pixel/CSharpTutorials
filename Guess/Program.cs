using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int attempts = 0;
            int limit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (attempts < limit)
                {   Console.Write("Guess the word: ");
                    guess = Console.ReadLine();
                    attempts++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else if (!outOfGuesses)
            {
                Console.WriteLine("You Win!");
            }
        }
    }
}
