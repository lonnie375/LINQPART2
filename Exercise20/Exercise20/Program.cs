// See https://aka.ms/new-console-template for more information
{
    bool choice = true;
    while (choice == true)
    {
        Console.Write("Enter a number: ");
        var userNumber = Console.ReadLine();
        int userFinalNumber;
        bool check = int.TryParse(userNumber, out userFinalNumber);

        if (check)
        {

        }
        else
        {
            Console.WriteLine("Please enter a number.");
            userNumber = Console.ReadLine();

        }


        for (int i = userFinalNumber; i == userFinalNumber; i++)
        {
            int first = userFinalNumber - 1;
            int second = userFinalNumber - 2;
            int product = userFinalNumber * first * second;
            Console.WriteLine($"The product of {userFinalNumber}, {first}, and {second} is {product}.");
        }


        Console.Write("Would you like to continue (y/n)? ");
        var userResponse = Console.ReadLine();

        if (userResponse == "y")
        {

        }
        else
        {
            Console.WriteLine("Good Bye");
            break;
        }

    }
}
