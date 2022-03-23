// See https://aka.ms/new-console-template for more information
//Ask for the users name
Console.Write("To get started provide your name: ");
string userName = Console.ReadLine();

Console.WriteLine();

string choice = "";
do
{
    //Ask the user to insert a number
    Console.Write("Enter a integer between 1 and 100: ");

    int userInput = int.Parse(Console.ReadLine());



    //Create if statement for conditions
    if (userInput % 2 != 0 && userInput < 60 && userInput >= 1)
    {
        Console.WriteLine();
        Console.WriteLine($"Output: {userInput}, Odd and less than 60.");
        Console.WriteLine();
        Console.Write($"{userName}, would you like to continue (y/n)?: ");
        Console.WriteLine();
        choice = Console.ReadLine();

    }
    else if (userInput % 2 == 0 && userInput >= 2 && userInput < 25)
    {
        Console.WriteLine();
        Console.WriteLine($"Output: {userInput}, Even and less than 25.");
        Console.WriteLine();
        Console.Write($"{userName}, would you like to continue (y/n)?: ");
        Console.WriteLine();
        choice = Console.ReadLine();
    }
    else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
    {
        Console.WriteLine();
        Console.WriteLine($"Output: {userInput}, Even and between 26 and 60 inclusive.");
        Console.WriteLine();
        Console.Write($"{userName}, would you like to continue (y/n)?: ");
        Console.WriteLine();
        choice = Console.ReadLine();
    }
    else if (userInput % 2 == 0 && userInput > 60 && userInput <= 100)
    {
        Console.WriteLine();
        Console.WriteLine($"{userInput}, Even and greater than 60.");
        Console.WriteLine();
        Console.Write($"{userName}, would you like to continue (y/n)?: ");
        Console.WriteLine();
        choice = Console.ReadLine();
    }
    else if (userInput % 2 != 0 && userInput > 60 && userInput <= 100)
    {
        Console.WriteLine();
        Console.WriteLine($"{userInput}, Odd and greater than 60.");
        Console.WriteLine();
        Console.Write($"{userName}, would you like to continue (y/n)?: ");
        Console.WriteLine();
        choice = Console.ReadLine();
    }

    else
    {
        Console.WriteLine();
        Console.WriteLine($"Please enter a number between 1 and 100, {userName}.");
        Console.WriteLine();
        Console.Write($"{userName}, would you like to continue (y/n)?: ");
        Console.WriteLine();
        choice = Console.ReadLine();

    }

}
while (choice == "y");
Console.WriteLine("Good Bye!");