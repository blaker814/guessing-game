using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Random r = new Random();
            int secretNum = r.Next(1, 101);
            int guess = 0;

            while (count < 5 && guess != secretNum)
            {
                Console.WriteLine("Can you guess the secret number?");
                Console.WriteLine($"Number of guesses left: {5 - count}");
                if (count > 1)
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
