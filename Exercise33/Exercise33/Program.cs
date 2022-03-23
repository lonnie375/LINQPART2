// See https://aka.ms/new-console-template for more information

bool choice = true;
do
{
    //Create an array that takes 5 elements
    int[] five = new int[5] { 2, 8, 0, 24, 51 };


    //Ask the user for the index they want to change 
    Console.Write("Enter an index of the array: ");
    int user;
    string userInput = Console.ReadLine();
    bool userChoice = int.TryParse(userInput, out user);

    if (user > 4)
    {
        Console.Write("That is not a valid index. Would you like to continue (y/n)? ");
        string userUpdate = Console.ReadLine();

        if (userUpdate == "y")
        {
            Console.Write("Enter an index of the array: ");
            int user1;
            string userInput1 = Console.ReadLine();
            bool userChoice1 = int.TryParse(userInput1, out user1);
        }
        else
        {
            Console.WriteLine("Goodbye!");
            break;
        }
    }

    //Create a variable to hold the value of the selected index
    int userResult = Array.IndexOf(five, user);

    if (userChoice == true)
    {

    }
    else
    {
        Console.WriteLine("Please enter a number between 0 -4");

    }


    //Ask the user if they want to change the index they have selected
    Console.Write($"The value at index {user} is {userResult}. Would you like to change it (y/n)? ");
    string userChange = Console.ReadLine();

    if (userChange == "y")
    {
        Console.Write($"Enter the new value at index 2: ");

    }
    else if (userChange == "n")
    {
        Console.Write("Would you like to continue (y/n)? ");
        string replyChange = Console.ReadLine();

        if (replyChange == "y")
        {

        }
        else if (replyChange == "n")
        {
            Console.WriteLine("Goodbye.");
            break;
        }
        else
        {
            Console.WriteLine("That is not a valid index. Would you like to continue (y/n)?");
        }
    }
    //Accept the users new value
    int value;
    string userValue = Console.ReadLine();
    bool usersValue = int.TryParse(userValue, out value);

    five[user] = value;

    var newValue = five[user];

    Console.Write($"The value at index {user} is {newValue}. Would you like to continue (y/n)? ");

    string userReply = Console.ReadLine();

    if (userReply == "y")
    {
        Console.Write("Enter an index of the array: ");
        int values;
        string userValues = Console.ReadLine();
        bool usersValues = int.TryParse(userValues, out values);

        Console.Write($"The value at index {values} is {newValue}. Would you like to change it (y/n)? ");
        string userChanges = Console.ReadLine();

        if (userChanges == "y")
        {

        }


    }
    else if (userReply == "n")
    {
        Console.Write("Would you like to continue (y/n)? ");

    }


    Console.Write("Would you like to continue (y/n)? ");
    string userResponse3 = Console.ReadLine();

    if (userResponse3 == "y")
    {


    }
    else if (userResponse3 == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    }


} while (choice == true);

