// See https://aka.ms/new-console-template for more information
class Program
{
    //Random instance that is going to be used throughout the program. 
    public static Random rnd = new Random();


    static void Main(string[] args)
    {
        //Welcome the user to Grand Circus 
        Console.WriteLine("Welcome to the Grand Circus Casino!");

        //Ask the user how many dies they want
        Console.Write("How many sides should each die have? ");
        //Create the variable the users input will be stored in
        int userFinalInput;
        var userInput = Console.ReadLine();
        //Create the statement to receive their input and check for incorrect inputs
        bool userConvert = int.TryParse(userInput, out userFinalInput);

        if (userConvert)
        {

        }
        else
        {
            Console.WriteLine("Please enter a number 1 - 12.");
        }



        //First roll
        Console.Write("Roll 1: ");
        Console.WriteLine();
        //Create a loop to repeat rolls if the user wants to
        bool choice = true;
        do
        {
            var firstDie = Program.firstNumber(userFinalInput);
            var secondDie = Program.firstNumber(userFinalInput);
            var sum = firstDie + secondDie;

            //Insert what the user rolled below
            Console.WriteLine($"You rolled a {firstDie} and a {secondDie} ({sum} total)");
            //Ask the user if they want to roll again
            Console.Write("Roll again? (y/n): ");

            //Record the users response
            var userResponse = Console.ReadLine();

            //Print out a statement if user selects 6 
            if (userFinalInput == 6)
            {
                var six = SixSide(firstDie, secondDie);
                Console.Write(six);

            }
            if (userFinalInput >= 1 && userFinalInput <= 12)
            {
                var random = DiceCombo(firstDie, secondDie);
                Console.Write(random);
            }




            //Create a rule for if they enter y or n
            if (userResponse == "y")
            {

            }
            else if (userResponse == "n")
            {
                Console.WriteLine("Thanks for playing!!");
                break;
            }
            else
            {
                Console.WriteLine("Please enter y or n.");
            }

            //Second Roll
            Console.WriteLine("Roll 2: ");





        } while (choice == true);



    }



    //Use a static method to generate the first random number
    public static int firstNumber(int userInput)
    {
    }
}
