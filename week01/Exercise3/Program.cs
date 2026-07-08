using System;

class Program
{
    static void Main(string[] args)
    {

    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1, 11);

    int intguess = 0;

    while (intguess != number)
    {
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        intguess = int.Parse(guess);

            if (intguess == number)
            {
                Console.WriteLine("You guessed it! ");

            }   

            else if (intguess > number)
            {
                Console.WriteLine("Lower ");
            }

            else if (intguess < number)
            {
                Console.WriteLine("Higher ");
            }
    }
    }
}