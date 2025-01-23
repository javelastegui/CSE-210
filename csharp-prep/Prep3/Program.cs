using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("What is the magic number? ");
        int response = int.Parse(Console.ReadLine());*/

        Random randomGenerator = new Random();
        int response = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != response)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > response)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < response)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}