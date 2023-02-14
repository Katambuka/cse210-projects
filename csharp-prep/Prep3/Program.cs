using System;

Console.WriteLine("Guess Random Number");
Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 91);

int guess = -1;

while (guess != magicNumber)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (magicNumber > guess)
    {
        Console.WriteLine("Your guess number is higher, try again");
    }
    else if (magicNumber < guess)
    {
        Console.WriteLine("You guessed a lower number, try again");
    }
    else
    {
        Console.WriteLine("You guessed it!. congraculations!!");
    }

}
