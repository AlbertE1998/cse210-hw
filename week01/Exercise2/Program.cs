using System;

class Program
{
    static void Main(string[] args)
    {

    Console.Write("What is your grade percentage? ");
    string gradeper = Console.ReadLine();
    int percentage = int.Parse(gradeper);

    string letter = "";

    if (percentage >= 90)
    {
        letter = "A";
    }

    else if (percentage >= 80 && percentage < 90)
    {
        letter = "B";
    }

    else if (percentage >= 70 && percentage < 80)
    {
        letter = "C";
    }

    else if (percentage >= 60 && percentage < 70)
    {
        letter = "D";
    }

    else
    {
        letter = "F";
    }

    Console.WriteLine($"Your grade is {letter}");

    if(percentage >= 70)
    Console.Write("Congratulations, you passed!");

    else
    Console.Write("You failed this time, I know you will succeed next!");
    }

}