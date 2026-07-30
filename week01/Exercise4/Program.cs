using System.Collections.Generic;

List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int userInput = -1;
while (userInput != 0)
{
    Console.Write("Enter number: ");
    userInput = int.Parse(Console.ReadLine());

    if (userInput != 0)
    {
        numbers.Add(userInput);
    }
}

// Sum
int sum = 0;
foreach (int n in numbers)
{
    sum += n;
}
Console.WriteLine($"The sum is: {sum}");

// Average
double average = (double)sum / numbers.Count;
Console.WriteLine($"The average is: {average}");

// Maximum
int max = numbers[0];
foreach (int n in numbers)
{
    if (n > max)
    {
        max = n;
    }
}
Console.WriteLine($"The largest number is: {max}");