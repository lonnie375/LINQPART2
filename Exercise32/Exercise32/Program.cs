// See https://aka.ms/new-console-template for more information

//Create an array of 5 elements
int[] five = new int[5] { 2, 8, 0, 24, 51 };

//Ask the user to enter a number
Console.Write("Enter a number: ");

bool choice = true;
do
{
    //Accept the users number
    int userNumber;
    string userInput = Console.ReadLine();
    bool userCheck = int.TryParse(userInput, out userNumber);

    if (userCheck == true)
    {
        //Check to see if the number is in the array
        bool numberCheck = five.Contains(userNumber);

        //Index of the number provided
        var numberIndex = Array.IndexOf(five, userNumber);

        if (numberCheck == true)
        {
            Console.WriteLine($"The value {userNumber} can be found at index {numberIndex}.");

        }
        else if (numberCheck == false)
        {
            Console.WriteLine("That value cannot be found in the array.");
        }

    }
    else if (userCheck == false)
    {
        Console.WriteLine("That value cannot be found in the array.");
    }


    Console.Write("Would you like to continue (y/n)? ");
    string userResponse = Console.ReadLine();

    if (userResponse == "y")
    {
        Console.Write("Enter an index of the array: ");
    }
    else
    {
        Console.WriteLine("Goodbye");
        continue;


    }




} while (choice == true);
