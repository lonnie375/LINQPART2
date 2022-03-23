// See https://aka.ms/new-console-template for more information

//This is in Unit 3 on the LMS.
//Make sure your grammar is good
//Make sure that you use the "Length" property for the array.

//When the user provides you with the number you have to conver their number to the index. Just subtract their number
//by one.

//You will be using string.join - you can look at your previous projects for information on this.
//Upload this to github and then provide them with your GitHub Link. 

//string.Join(", " nameofArray);

string[] nameArray = new string[9] { "Samuel", "Salvestor", "Steve", "Steven", "Stephen", "Sean", "Spencer", "Simon", "Silas" };

string[] homeTownArray = new string[9] { "Dalls", "Denver", "Detroit", "Durham", "Des Moins", "Dayton", "Dearborn", "Daytona Beach", "Decatur" };


string[] favoriteFood = new string[9] { "Sweet potato", "Salmon", "Shrimp", "Steak", "Swordfish", "Spaghetti", "Shephard's pie", "Sushi", "Submarine Sandwiches" };

//Ask the user about a student from the nameArray
Console.Write("Welcome! Which student would you like to learn more about? Enter a number 1 - 9: ");


var userInput = int.Parse(Console.ReadLine());

bool choice = true;
do
{
    //Print an error if the number for the student is out of range
    bool firstCase = true;
    while (firstCase)
    {
        if (userInput < 1 || userInput > nameArray.Length)
        {
            Console.WriteLine("Please insert a number between 1 and 9.");
            userInput = int.Parse(Console.ReadLine());
        }
        else
        {
            firstCase = false;
        }
    }


    //Convert users number by 1 to get the proper index
    var studentIndex = userInput - 1;
    var studentChoice = nameArray[studentIndex];

    //Ask the user what they would like to know about the student they selected
    Console.Write($"Student {userInput} is {studentChoice}. What would you like to know? Enter 'hometown or 'favorite food': ");
    string userInput2 = Console.ReadLine();


    //Provide the response for 'hometown'
    var homeTown = studentIndex;
    var studentHomeTown = homeTownArray[homeTown];


    //Provide the response for 'favorite food'
    var food = studentIndex;
    var favFood = favoriteFood[food];


    //Create a while loop to make sure the user inputs "hometown", "favorite food", or food. 
    bool newCase = true;
    while (newCase)
    {
        if (userInput2 == "hometown")
        {
            Console.WriteLine($"{studentChoice} is from {studentHomeTown}.");
            newCase = false;
        }
        else if (userInput2 == "favorite food")
        {
            Console.WriteLine($"{studentChoice} favorite food is {favFood}.");
            newCase = false;
        }
        else if (userInput2 == "food")
        {
            Console.WriteLine($"{studentChoice} favorite food is {favFood}.");
            newCase = false;
        }
        else
        {
            Console.WriteLine("Please enter either hometown or favorite food.");
            userInput2 = Console.ReadLine();
        }
    }

    //Ask the user if they want to learn about another student
    Console.Write("Would you like to learn about another student? Enter 'y' or 'n': ");
    string userReturn = Console.ReadLine();

    bool learn = true;
    while (learn)
    {
        if (userReturn == "y" || userReturn == "yes")
        {
            learn = false;
        }
        else if (userReturn == "n" || userReturn == "no")
        {
            learn = false;

        }
        else
        {
            Console.WriteLine("Please enter 'y' or 'n': ");
            userReturn = Console.ReadLine();
        }
    }

    //Do they want to quit or not. 
    if (userReturn == "n" || userReturn == "no")
    {
        Console.WriteLine("Thanks");
        break;
    }


    Console.Write("Which student would you like to learn more about? Enter a number 1-9: ");
    userInput = int.Parse(Console.ReadLine());

} while (choice == true);
