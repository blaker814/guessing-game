using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secret number?");
            Console.Write("Your guess: ");
            int secretNum = 42;
            int guess = int.Parse(Console.ReadLine());
            if (secretNum == guess)
            {
                Console.WriteLine("That's right!");
            }
            else
            {
                Console.WriteLine("WRONG!");
            }
        }
    }
}
