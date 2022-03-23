// See https://aka.ms/new-console-template for more information

{
    bool choice = true;
    do
    {
        //Create the array that holds 5 elements
        int[] five = new int[5] { 2, 8, 0, 24, 51 };

        Console.Write("Enter an index of the array: ");
        int user;
        string userInput = Console.ReadLine();
        bool usersInput = int.TryParse(userInput, out user);

        if (user > 4 || user < 0)
        {
            Console.WriteLine("That is not a valid index.");
            Console.Write("Would you liek to continue (y/n)? ");
            string usersResponse = Console.ReadLine();
            if (usersResponse == "y")
            {
                continue;
            }
            else if (usersResponse == "n")
            {
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("Please enter y or n");
            }
        }

        int userIndex = five[user];
        Console.WriteLine($"The value at index {user} is {userIndex}");

        Console.Write("Would you like to continue (y/n)? ");
        string userResponse = Console.ReadLine();

        if (userResponse == "y")
        {
            continue;
        }
        else if (userResponse == "n")
        {
            Console.WriteLine("Goodbye");
            break;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    } while (choice == true);
}
