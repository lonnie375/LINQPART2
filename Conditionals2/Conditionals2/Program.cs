// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give me a number.");
var userInput = Console.ReadLine();

var guessedNumber = int.Parse(userInput);

var isStillLooping = true;

//This loop will stop running when guessedNumber is greater than 9

do
{
    Console.WriteLine(guessedNumber);
    guessedNumber++;

    if (guessedNumber > 9)
    {
        isStillLooping = false;
    }
}
while (isStillLooping == true);


//This is the same as writing "isStillLooping == true"
while (isStillLooping)
{
    Console.WriteLine(guessedNumber);
    guessedNumber++;

    if (guessedNumber > 9)
    {
        isStillLooping = false;
    }
}





for (var i = 0; i < 10; i++)
{
    Console.WriteLine(guessedNumber);
    guessedNumber++;
}
