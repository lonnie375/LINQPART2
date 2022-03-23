// See https://aka.ms/new-console-template for more information

bool user = true;
while (user == true)
{
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int userInput = int.Parse(input);
    for (int i = userInput; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.Write("Would you like to continue (y/n)? ");
    input = Console.ReadLine();

    if (input == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        user = false;
    }
}
