// See https://aka.ms/new-console-template for more information
bool user = true;
while (user == true)
{
    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine(string.Join(",", i));
    }
    Console.Write("Would you like to continue (y/n)? ");
    string userInput = Console.ReadLine();

    if (userInput == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        user = false;
    }

}
