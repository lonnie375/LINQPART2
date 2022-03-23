// See https://aka.ms/new-console-template for more information

//This program will run if the user puts all the right input in
//However, the user is the enemy, so we need to make sure it functions with no run time errors
//There may also be LOGICAL errors in this program

//Our database consists of the store items and a list of customers who have shopped here before.
using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, decimal> storeItems = new Dictionary<string, decimal>()
{
    { "Widget", 1.25m },
    { "Sprocket", 2.75m },
    { "Thingamabobs", 10.45m },
    { "Sliced Bread", 5.45m },
    { "Headphones", 50.95m },
    { "TV", 500.00m }
};

List<string> currentCustomerList = new List<string>()
{
    "Harry",
    "Betsy",
    "Mergatroid",
    "Larry",
    "Joe",
    "Shannon",
    "Jonathan",
    "Cassly"
};

var isShopping = true;
bool isCurrentCustomer = false; //This isn't used within the program. Can we use this or shoudld this be removed? 
var shoppingCart = new List<string>();
var priceList = new List<decimal>();




Console.WriteLine("Welcome to FaceAzonGoogleAppleFlix! Type in your name! Returning customers get 10% off!"); //Returning customers should receive discounts. 

do
{
    
    var currentCustomerInput = Console.ReadLine(); //user can enter a number or doesn't press anything. *****
    bool choice = true;
    do
    {
        try
        {
            var customerFound = currentCustomerList.Where(x => x == currentCustomerInput).First();

        }
        catch (InvalidOperationException invalid)
        {
            Console.WriteLine(invalid.Message);
            Console.WriteLine("Please Enter a name from the list above exactly as it is written.");
            currentCustomerInput = Console.ReadLine();

        }

        //This is needed to get out of the loop!
        if (currentCustomerList.Contains(currentCustomerInput))
        {
            choice = false;
        }

    } while (choice == true);

     
   


    //Ask the user if they are a returning customer  ****
    Console.Write("Have you shopped here before (y/n)?: "); //Account for if they don't enter y or n 
    string userReturn = Console.ReadLine().ToLower().ToUpper();
    bool choice2 = true; 
    while (choice2 == true)
    {
        if (userReturn == "y" || userReturn == "Y")
        {
            Console.WriteLine($"Welcome back {currentCustomerInput}!");
            Console.WriteLine("You will recieve a 10% discount.");
    
            choice2 = false; 
        }
        else if (userReturn == "n" || userReturn == "N")
        {
            
            Console.WriteLine("Thank you.");
            choice2 = false; 
        }
        else
        {
            Console.WriteLine("Please enter 'y' or 'n'.");
            userReturn = Console.ReadLine();
        }
    }

    bool choice5 = true;

    while (choice5 == true)
    {


        Console.WriteLine("Here is our list of items:");

        PrintItemList();

        Console.WriteLine("What would you like from the list above? Please insert selection as is.");

        var userInput = Console.ReadLine(); // We also have to make sure that they select from the list given in that format ***

        bool choice3 = true;
        while (choice3 == true)
        {
            if (storeItems.ContainsKey(userInput))
            {
                choice3 = false;
            }
            else
            {
                Console.WriteLine("Please enter an item from the list above as it is written.");
                userInput = Console.ReadLine();
            }
        }

        Console.WriteLine("How many of those would you like?");

        //Will need to handle FormatException

        string howManyItems = Console.ReadLine();
        int items;
        bool numberOfItems = int.TryParse(howManyItems, out items); //What happens if the user doesn't enter a integer? //Update this to reflect TryParse 

        bool choice4 = true;
        while (choice4 == true)
        {

            if (numberOfItems)
            {

                break;

            }


            else
            {
                Console.WriteLine("Please enter an integer.");
                howManyItems = Console.ReadLine();
                numberOfItems = int.TryParse(howManyItems, out items); //What happens if the user doesn't enter a integer? //Update this to reflect TryParse 
            }

        }

        for (int i = 0; i < items; i++)
        {
            shoppingCart.Add(userInput);
            priceList.Add(storeItems[userInput]);
        }


        Console.WriteLine($"{userInput} costs ${storeItems[userInput]} per item and {items} have been added to your cart!"); //This sentence can be improved 

        Console.Write("Would you like to continue shopping (y/n)?: "); //Instruct the user on how they are to respond 

        var continueShopping = Console.ReadLine(); //Allow user to enter lower and capital letters 

        if (continueShopping == "y" || continueShopping == "yes")
        {
            continue;
        }
        else
        {
            break; 
        }
    }  
            Console.WriteLine("Time to check out!");
            Console.WriteLine("Here's what you bought:");
            foreach (var str in shoppingCart)
            {
                Console.WriteLine(str);
            }

            decimal total = 0;


    



            foreach (decimal dec in priceList)
            {
                total += dec ;
                   


                //apply the discount 
                if (userReturn == "y" || userReturn == "Y")
                {
                    decimal discount = total * .1m;
                    decimal newTotal = total - discount;
                    Console.WriteLine($"Your total comes out to be: {newTotal}"); //Apply discount to the users who return 
                }
                else
                {
                    Console.WriteLine($"Your total comes out to be: {total}");
                }



                Console.WriteLine($"See you next time {currentCustomerInput}!");
                break;
    }
        
    
} while (isShopping);


    void PrintItemList()
    {
        foreach (KeyValuePair<string, decimal> kvp in storeItems)
        {
            Console.WriteLine(kvp.Key + ": $" + kvp.Value);
        }
    }

