// See https://aka.ms/new-console-template for more information
//try contains key method to see if we can do this

bool choice = true;
do
{
    //Lets create the dictionary
    Dictionary<string, string> language = new Dictionary<string, string>();
    language.Add("hello", "hello in Spanish is hola.");
    language.Add("world", "world in Spanish is mundo.");
    language.Add("playing", "playing cannot be translated.");



    Console.Write("Enter a word in English: ");
    string userInput = Console.ReadLine();

    if (userInput == "hello")
    {
        Console.WriteLine(language["hello"]);
    }
    else if (userInput == "world")
    {
        Console.WriteLine(language["world"]);
    }
    else if (userInput == "playing")
    {
        Console.WriteLine(language["playing"]);
    }

    Console.Write("Would you like to continue (y/n): ");
    string userChoice = Console.ReadLine();

    if (userChoice == "y")
    {

    }
    else
    {
        Console.WriteLine("Goodbye");
        break;
    }



} while (choice == true);
