using System.Collections.Generic;

int numbsum = -1;
List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of number, type 0 when finished.");

while (numbsum != 0 )
{
    Console.Write("Enter number: ");
    string number = Console.ReadLine();
    numbsum = int.Parse(number);

    if (numbsum != 0)
    {
        numbers.Add(numbsum);
    }
        
}

int sum = 0;
int largest = numbers[0];

foreach (int num in numbers)
{
    sum += num;

    if(num > largest )
    {
        largest =num;
    }
}

double average = (double)sum / numbers.Count;

Console.WriteLine($"The sum is : {sum}");
Console.WriteLine($"The average is : {average}");
Console.WriteLine($"The largest number is: {largest}");
