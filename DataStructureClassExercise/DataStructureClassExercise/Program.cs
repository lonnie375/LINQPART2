// See https://aka.ms/new-console-template for more information
//Create the Grocery List
List<string> groceryList = new List<string>();
bool choice = true;
do
{

    //Ask the user to add items to your list
    Console.WriteLine("Please add items to your grocery list.");
    string userInput = Console.ReadLine();

    //Add your users input to the grocerylist 
    groceryList.Add(userInput);

    Console.WriteLine("Would you like to continue (y/n)? ");
    string userResponse = Console.ReadLine();

    //Prepare the code to continue if they want to add more items and quit if they don't
    if (userResponse == "y")
    {
        continue;
    }
    else
    {

        break;
    }


} while (choice == true);

//Print out the items they want 
var usersItems = string.Join(",", groceryList);


Console.WriteLine($"You have selected {usersItems}, and we are giving you an apple on the house.");

