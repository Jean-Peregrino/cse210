using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
       do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guesses = 0;

            Console.WriteLine("Welcome to the Guessing Game!");

            int guess = -1;
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guesses} guesses to find the magic number!");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        while (playAgain.ToLower() == "yes");

    }
    
}