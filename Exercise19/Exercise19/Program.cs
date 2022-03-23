// See https://aka.ms/new-console-template for more information
bool choice = true;
while (choice == true)
{
    Console.Write("Enter a number: ");
    var userFirstNumber = Console.ReadLine();
    int usersFirstNumber;
    bool firstNumber = int.TryParse(userFirstNumber, out usersFirstNumber);

    Console.Write("Enter another number: ");
    var userSecondNumber = Console.ReadLine();
    int usersSecondNumber;
    bool secondNumber = int.TryParse(userSecondNumber, out usersSecondNumber);

    if (firstNumber && secondNumber)
    {

    }
    else
    {
        Console.WriteLine("Please make sure your first and second values are numbers.");
        continue;

    }

    int start = usersFirstNumber;
    int end = usersSecondNumber;
    int sum = 0;
    for (int i = usersFirstNumber; i <= usersSecondNumber; i++)
    {
        sum += i;
    }
    Console.WriteLine($"The sum of all the numbers from {usersFirstNumber} to {usersSecondNumber} is {sum}");

    Console.Write("Would you like to continue (y/n)? ");
    var userResponse = Console.ReadLine();

    if (userResponse == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        break;
    }


}

