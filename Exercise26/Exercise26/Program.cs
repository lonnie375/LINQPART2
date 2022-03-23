// See https://aka.ms/new-console-template for more information
string choice = "y";
do
{   //Exercise 24 
    //Ask the user to enter some text
    Console.Write("Enter some text: ");
    string userInput = Console.ReadLine();

    //Add correction if the text is not longer than 10 characters 
    if (userInput.Length < 10)
    {
        Console.WriteLine("Please enter at least 10 characters.");
        continue;
    }

    //Measure the length of the text inserted and count back 10
    string result = userInput.Substring(userInput.Length - 10);
    Console.WriteLine($"The last ten characters were: {result}");



    //Ask the user if they want to continue
    Console.Write("Would you like to continue (y/n)? ");
    string userChoice = Console.ReadLine();

    if (userChoice == "n" || userChoice == "No")
    {
        Console.WriteLine("Goodbye!");
        break;
    }



} while (choice == "y");
