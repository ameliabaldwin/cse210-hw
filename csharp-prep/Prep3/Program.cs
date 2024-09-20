using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 100);

       int Guess = -1;

        while (Guess != MagicNumber)
        {
            Console.Write("What is Your Guess? ");
            Guess = int.Parse(Console.ReadLine());

            if (Guess > MagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (Guess < MagicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
    }
}