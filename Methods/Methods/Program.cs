// See https://aka.ms/new-console-template for more information

//Will give you a random number
//First number is inclusive and the second number is excluseive
//This will create a number between 1 and 7
//Dice roller is the lab that we have 
var rand = new Random();


for (int i = 0; i < 5; i++) 
{
    var randomNumber = rand.Next(1, 7);
    Console.WriteLine(randomNumber);
}

var userInput = Console.ReadLine();


            /*
            //new is instantiate because you're creating a new calculator. 
            var calc = new Calculator();
            var userName = calc.AskUserName();
             
            Console.WriteLine(userName);

            var sum = calc.Add(1, 2);
            Console.WriteLine("Your sum is : " + sum);
            */

        
        //public means it is universally acceptable
        // 2nd part is what does the method return to us
        //3rd name the integer
        // Curly Braces
        // you expect to receive an integer when Add() is run
        // Inside of the parenthis list the data type and the then the name. Separate multiple by comas
        // Should be Pascale Case.
        


       /* Void=== returns nothing. They are just sent to do their job. This is why there is the error below. 
        public void NewMethod()
        {
            var finalNumber = 10;
            return finalNumber; 
        }
       */


    

    //separate class
    // You are going to be putting things that pertain to the "Calculator" below"
    //Start with access (public or private)
    //Keywork "class"
    //Lastly the name of the thing you're working on
     public class Calculator
{

    public int Add(int firstNum, int secondNum)
    {
        var finalNumber = firstNum + secondNum;

        return finalNumber;
    }

    public string AskUserName()
    {
        Console.WriteLine("Please give me your name: ");
        var userInput = Console.ReadLine();
        return userInput;
    }
}
