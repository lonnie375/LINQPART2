// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Give me a number (integer): ");
var userInput = Console.ReadLine();

int guestNumber = int.Parse(userInput);


if (guestNumber >= 10)
{
    Console.WriteLine("Wow, that's a big number.");
}
else if (guestNumber > 4 && guestNumber < 10)
{
    Console.WriteLine("Your number is between 4 and 10.");

}
else
{
    Console.WriteLine("Man that's a small number.");
    var blah2 = Console.ReadLine();
}



//Lets practice loops

do
{
    Console.WriteLine(guestNumber);
    guestNumber++;
}
while (guestNumber < 10);


for (var i = 0; i > guestNumber; i--)
{
    Console.WriteLine(i);
}