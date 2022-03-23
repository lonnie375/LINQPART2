// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string choice = "true";
do
{
    Console.WriteLine("Hello, World!");
    Console.Write("Would you like to Continue (y/n): ");
    string userInput = Console.ReadLine();

    if (userInput == "y")
    {
        continue;

    }
    else if (userInput == "n")
    {
        Console.WriteLine("Have a good day.");
        break;
    }

    Console.WriteLine("Would you like to Continue (y/n): ");

}
while (choice == "true");
