// See https://aka.ms/new-console-template for more information
string choice = "true";
do
{

    Console.Write("Enter your height in inches: ");
    string userHeight = Console.ReadLine();
    decimal height = decimal.Parse(userHeight);
    decimal requiredHeight = 54;
    decimal heightDiff = requiredHeight - height;


    if (height < 54)
    {
        Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {heightDiff} more inches.");

    }
    else
    {
        Console.WriteLine("Great, you can ride the Raptor!");

    }
    Console.Write("Would you like to continue (y/n)? ");
    string userChoice = Console.ReadLine();

    if (userChoice == "y")
    {
        continue;
    }
    else
    {
        break;
    }


} while (choice == "true");
Console.WriteLine("Goodbye!");
