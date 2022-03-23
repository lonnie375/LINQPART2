// See https://aka.ms/new-console-template for more information

//TryParse is used to help your code overcome exceptions.
//Out allows the information to be stored in parsedInt
//TryParse returns a boolean
//This creates a fail safe for if the user doesn't enter an integer. It won't break the code but it will alert you.
//TryParse is trying to convert userInput which is a string to an integer.
//If it comes back as a integer then it prints parsedInt. If not, then it prints "Hey that's not an integer."
//TryParse is used for Runtime errors. 
bool love = true;
do
{
    Console.WriteLine("Give me a number: ");
    var userInput = Console.ReadLine();

    int parsedInt;
    var isInt = int.TryParse(userInput, out parsedInt);

    if (isInt)
    {
        Console.WriteLine(parsedInt);
    }
    else
    {
        Console.WriteLine("Hey that's not an integer.");
    }

} while (love == true);


