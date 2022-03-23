// See https://aka.ms/new-console-template for more information
//Create an array of size 5
int[] five = new int[5] { 16, 32, 64, 128, 256 };
bool choice = true;
do
{
    //Ask the user to enter 'half' or 'double'
    Console.Write("Enter a command (half/double): ");
    string userCommand = Console.ReadLine();

    if (userCommand == "half" || userCommand == "double")
    {

    }
    else
    {
        Console.WriteLine("Please enter half or double as your command.");
    }

    //User selects half
    if (userCommand == "half")
    {
        //Divide elements in the array by half 
        five = Array.ConvertAll(five, x => x / 2);

        //lets put the elements in the form of a string/line to match instructions 
        var newArray = string.Join(" ", five);

        Console.WriteLine($"The array now contains: {newArray}");


    }
    else if (userCommand == "double")
    {
        //Multiply the elements in the array by 2
        five = Array.ConvertAll(five, x => x * 2);

        //lets put the elements in the form of a string/line to match instructions
        var newArray = string.Join(" ", five);

        Console.WriteLine($"The array now contains: {newArray}");
    }
    Console.Write("Would you like to continue (y/n)? ");
    string userResponse = Console.ReadLine();

    //new Array for half 
    int[] five2 = new int[5];
    //Create new array for client to work on for half 
    Array.Copy(five, five2, 5);

    //New Array for double
    int[] five3 = new int[5];

    //Create new array for client to work on for half
    Array.Copy(five, five3, 5);

    if (userResponse == "y")
    {
        //Divide elements in the array by half
        five2 = Array.ConvertAll(five2, x => x / 2);

        //Multiple elements by two
        five3 = Array.ConvertAll(five3, x => x * 2);

    }

    else
    {
        Console.WriteLine("Goodbye!");
        break;
    }

} while (choice == true);
