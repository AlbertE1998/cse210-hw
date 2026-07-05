Console.Write("What is your grade percentage?");
string gradeper = Console.ReadLine();
int percentage = int.Parse(gradeper);

if (percentage >= 90)
{
    Console.Write("A");
}

else if (percentage >= 80 && percentage < 89)
{
    Console.Write("B");
}