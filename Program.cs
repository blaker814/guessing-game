using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int secretNum = 42;
            int guess = 0;

            while (count < 5 && guess != secretNum)
            {
                Console.WriteLine("Can you guess the secret number?");
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
                }
                count++;
            }
        }
    }
}
