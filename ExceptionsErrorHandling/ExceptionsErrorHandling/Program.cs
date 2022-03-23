// See https://aka.ms/new-console-template for more information
//Understand the difference between Runtime Errors Vs Compile Time Errors
/*
 * Compile-Time is generally referring to semantics or syntax. 
 * Runtime - refers to the erorr that we encounter during the code execution during runtime. 
 * A complier cannot identify a runtime error. 
 */

//Errorhandling
/*Errorhandling is oftentimes dealt with by using if statements */

//Padding Strings
/* you can use "PadRight or PadLeft"*/


//Try Catch lets your program keep running if something bad happens. 
//Try parse could fail, getting back 0 could fail. In these cases a try catch may be a good option
//It is your job as a programmer to predict potential issues with your code 
//You can have multiple catches also. But they havee to deal with a  different exception. This is where you can
//look on  the exception cheat list.
//The exception has to be last


var continueLoop = true;
do
{
    Console.WriteLine("Wlcome to the division machine!");
    Console.WriteLine("give me a number and I'll divide 10 by it!");

    var userInput = Console.ReadLine();

    try
    {
        //Takes  into consideration  if the user doesn't enter anything. 
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Sorry you need to type something.");
            continue;
        }
        //Put all the code that could have a run time error here
        int number = int.Parse(userInput);
        var divide = 10 / number;

        Console.WriteLine($"You type in {number}  {divide}");
        break;
    }
    catch (FormatException luv)
    {
        Console.WriteLine(luv.Message);
        Console.WriteLine("Please give me an integer.");

    }
    catch (Exception ex)
    {
        //Prints the error message to the user so that they know what information they need to insert. 
        Console.WriteLine(ex.Message);

        //ask the user to try again 
        Console.WriteLine("Hey try that again.");

    }

    finally
    {
        //Whatever happens, this code runs 
        //this one is optional you don't need this. 
    }


} while (continueLoop);


