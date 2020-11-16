using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please choose your mode:
            1) Easy Mode - 8 guesses
            2) Medium Mode - 6 guesses
            3) Hard Mode - 4 guesses");
            int modeChoice = int.Parse(Console.ReadLine());
            int numGuesses = 0;
            if (modeChoice == 1)
            {
                Console.WriteLine("Easy mode activated");
                numGuesses = 8;
            }
            else if (modeChoice == 2)
            {
                Console.WriteLine("Medium mode activated");
                numGuesses = 6;
            }
            else if (modeChoice == 3)
            {
                Console.WriteLine("Hard mode activated");
                numGuesses = 4;
            }
            int count = 0;
            Random r = new Random();
            int secretNum = r.Next(1, 101);
            int guess = 0;

            while (count < numGuesses && guess != secretNum)
            {
                Console.WriteLine("Can you guess the secret number?");
                Console.WriteLine($"Number of guesses left: {numGuesses - count}");
                if (count > 0)
                {
                    Console.Write($"Your guess ({guess}): ");
                }
                else
                {
                    Console.Write($"Your guess: ");
                }
                guess = int.Parse(Console.ReadLine());

                if (secretNum == guess)
                {
                    Console.WriteLine("That's right!");
                }
                else
                {
                    Console.WriteLine("WRONG!");
                    if (guess > secretNum)
                    {
                        Console.WriteLine("Your guess was too high");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too low");
                    }
                }
                count++;
            }
        }
    }
}
