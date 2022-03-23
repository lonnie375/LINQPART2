// See https://aka.ms/new-console-template for more information
bool exercise = true;
while (exercise == true)
{
    Console.Write("Enter a number: ");
    var userNumber = Console.ReadLine();
    int usersNumber;
    bool number = int.TryParse(userNumber, out usersNumber);

    if (number)
    {

    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("You did not enter an integer, please try again.");
    }

    for (int i = 1; i <= usersNumber; i++)
    {
        int cube = i * i * i;
        Console.WriteLine(cube);
    }

    Console.Write("Would you like to continue (y/n)? ");
    string userOption = Console.ReadLine();

    if (userOption == "y")
    {
        continue;
    }
    else if (userOption == "n")
    {

        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Please enter (y/n).");

        continue;
    }
}

