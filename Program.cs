using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int secretNum = 42;

            while (count < 5)
            {
                Console.WriteLine("Can you guess the secret number?");
                Console.Write("Your guess: ");
                int guess = int.Parse(Console.ReadLine());

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
