using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secret number?");
            Console.Write("Your guess: ");
            string guess = Console.ReadLine();
            Console.WriteLine(guess);
        }
    }
}
