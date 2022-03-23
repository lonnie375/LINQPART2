// See https://aka.ms/new-console-template for more information

//The key for this exercise is to use two do while loops 
string keepGoing = "y";
do
{
    string yn = "y";
    string completeString = " ";
    string userString = " ";

    do
    {
        Console.WriteLine("Enter a word: ");
        userString = Console.ReadLine();
        completeString += userString;

        Console.WriteLine("Would you like to enter more words? ");
        yn = Console.ReadLine();
    } while (yn == "y");
    Console.WriteLine(completeString);
    Console.WriteLine("Would you like to continue?");
    keepGoing = Console.ReadLine();
}
while (keepGoing == "y");

