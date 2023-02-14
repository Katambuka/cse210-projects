using System;
using System.Collections.Generic;

Console.WriteLine("Hello Prep4 World!");
List<string> words = new()
{
    "Name:",
    "Phone:",
    "Location:"
};
Console.WriteLine("Words are add to the system");
// counting words
Console.WriteLine(words.Count);
// using new syntax foreach
foreach (string word in words)
{
    Console.WriteLine(word);
}
//using for in C#
for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}

// assignment for prep 4
List<int> numbers = new();
int userNumber = -1;
while (userNumber != 0)
{
    Console.Write("Enter the number 0 to quit the program.");
    string userResponse = Console.ReadLine();
    userNumber = int.Parse(userResponse);
    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    Console.WriteLine($"The sum of numbers is {sum}");

    // find average
    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");
    int max = numbers[0];

    foreach (int number in numbers)
    {
        if (number > max)
        {
            // if this number is greater than the max, we have found the new max!
            max = number;
        }
    }

    Console.WriteLine($"The max is: {max}");
}
