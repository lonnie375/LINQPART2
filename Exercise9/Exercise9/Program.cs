// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string userChoice = "";
do
{
    Console.Write("Enter a language: ");
    string userLanguage = Console.ReadLine();

    switch (userLanguage)
    {
        case "English":
            Console.WriteLine("Hello, World!");
            Console.Write("Would you like to continue (y/n)?: ");
            userChoice = Console.ReadLine();
            break;
        case "Spanish":
            Console.WriteLine("Hola Mundo!");
            Console.Write("Would you like to continue (y/n)?: ");
            userChoice = Console.ReadLine();
            break;
        case "Dutch":
            Console.WriteLine("Hallo wereld!");
            Console.Write("Would you like to continue (y/n)?: ");
            userChoice = Console.ReadLine();
            break;
        default:
            Console.WriteLine("Please insert your langugage.");
            break;
    }
} while (userChoice == "y");

Console.WriteLine("Goodbye!");