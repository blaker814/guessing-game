using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = chosenMode();
            int totalGuesses = numOfGuesses(mode);

            int count = 0;
            Random r = new Random();
            int secretNum = r.Next(1, 101);
            int guess = 0;
            if (totalGuesses == 1)
            {
                while (guess != secretNum)
                {
                    Console.WriteLine("Can you guess the secret number?");
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
            else
            {
                while (count < totalGuesses && guess != secretNum)
                {
                    Console.WriteLine("Can you guess the secret number?");
                    Console.WriteLine($"Number of guesses left: {totalGuesses - count}");
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
        static string chosenMode()
        {
            string modeChoice = "";
            while (modeChoice != "1" && modeChoice != "2" && modeChoice != "3" && modeChoice != "4")
            {
                Console.WriteLine(@"Please choose your mode:
                1) Easy Mode - 8 guesses
                2) Medium Mode - 6 guesses
                3) Hard Mode - 4 guesses
                4) Cheater mode - No guess limit");
                modeChoice = Console.ReadLine();
            }
            return modeChoice;
        }
        static int numOfGuesses(string modeChoice)
        {
            int numGuesses;
            if (modeChoice == "1")
            {
                Console.WriteLine("Easy mode activated");
                numGuesses = 8;
                return numGuesses;
            }
            else if (modeChoice == "2")
            {
                Console.WriteLine("Medium mode activated");
                numGuesses = 6;
                return numGuesses;
            }
            else if (modeChoice == "3")
            {
                Console.WriteLine("Hard mode activated");
                numGuesses = 4;
                return numGuesses;
            }
            else
            {
                Console.WriteLine("Cheater mode activated");
                numGuesses = 1;
                return numGuesses;
            }
        }
    }
}
