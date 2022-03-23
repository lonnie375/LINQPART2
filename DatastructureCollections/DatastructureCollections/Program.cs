// See https://aka.ms/new-console-template for more information
//Arrays are a part of data structures as well. They hold data in a line. They are all one type.
//Data Structures help you organize data
//Collections are similar to an array. They are used to hold other objects.
//Collections are more flexible and efficient than arrays.
//Types of collections


//Non-Generic Collections
//They aren't strong typed so you don't have to identify the data type. They have no safety net
//Any type of data can go in and any type may come out. You will do a lot of parsing or costing.
//They are used in the real world a lot because it is easy for them to cause errors.
//Examples are (Arraylists and Hashtables)

/* ArrayList 
 * This is an Array that can change it's capacity or size as elements are added or removed. 
 */

//Add the using System.Collections which is above!


using System.Collections;

var arrayList = new ArrayList();

arrayList.Add(5);
arrayList.Add("Banna");
arrayList.Add(4.67);
arrayList.Add(15);

//Count prints out the number of elements we have. We have 3 Elements (5, Banna, and 4.67) 
//Console.WriteLine(arrayList.Count);
//Console.WriteLine(arrayList[0]); 

//The for loop below keeps the order that the elements were added to the array. 
for (var i = 0; i < arrayList.Count; i++)
{
    // Console.WriteLine(arrayList[i]); 
}


/*Insert
 * This adds your code to a specific index. We added 1000 to index 1*/
//This is more so used in real world situations. 
arrayList.Insert(1, 1000);

for (int i = 0; i < arrayList.Count; i++)
{
    //Console.WriteLine(arrayList[i]); 
}






/* List 
 * this is what you are going to use 99% of the time*/
//This creates a list of integers only
//This is strongly typed
//The size of the list isn't fixed. You can add new things later on
//This uses System.Collections.Generic 
List<int> integerList = new List<int>();

integerList.Add(1000);

//You can also write list as follows:
//Use a for loop or foreach to run this. 
List<int> intList = new List<int>()
            {
                1000, 500, 250, 50
            };

foreach (int integer in intList)
{
    Console.WriteLine(integer);
}

List<string> stringList = new List<string>();




List<string> whateverWeWannaCallIt = new List<string>();

whateverWeWannaCallIt.Add("orange");
whateverWeWannaCallIt.Add("Banana");
whateverWeWannaCallIt.Add("Apple");

// Console.WriteLine(string.Join(",", whateverWeWannaCallIt));

//To remove Banana from the list 
whateverWeWannaCallIt.Remove("Banana");

// Console.WriteLine(string.Join(",", whateverWeWannaCallIt));


//Sum Method with list

List<int> listOfIntegers = new List<int>()
            {
                10,
                2500,
                15,
                85,
                37,
                1050
            };

//var currentSum = listOfIntegers.Sum();
//Console.WriteLine(currentSum);

//Min - gives you the smallest number
var currentMin = listOfIntegers.Min();
//Console.WriteLine(currentMin);

//Prints out the largest value 
var currentMax = listOfIntegers.Max();
//Console.WriteLine(currentMax);

//Count - tells you the number of items you have in your list 
var countInt = listOfIntegers.Count;
//Console.WriteLine(countInt);

// Console.WriteLine(listOfIntegers[0]);

//Using list as a parameter for a method
GetCountOfList(listOfIntegers);
int GetCountOfList(List<int> listOfInt)
{
    return listOfInt.Count;
}






//Hashtable
//Won't see this in the wild often


//Dictionaries
//The word is the key and the definition is the value
//We are matching data with each other. Linking keys to values
//This is strongly typed
//This is good for looking things up
//They are very fast. 

//string is the key and the second string is the value
Dictionary<string, string> dictionaryWords = new Dictionary<string, string>();
Dictionary<string, string> dictionaryWords2 = new Dictionary<string, string>();


//below is an example 
Dictionary<string, string> variableName = new Dictionary<string, string>();
variableName.Add("Bob", "His hometown is in Connecticut");
variableName.Add("Joe", "His hometown is in New Jersey");
variableName.Add("Steven", "His hometown is in Beijing");

//How to access the value for the keys
//Console.WriteLine(variableName["Steven"]);
//Console.WriteLine(variableName["Bob"]);
// Console.WriteLine(variableName["Joe"]);


//How you iterate through a dictionary
foreach (KeyValuePair<string, string> keyValuePair in variableName)
{
    //Console.WriteLine(keyValuePair.Key);
    //Console.WriteLine(keyValuePair.Value); 
}





//Stacks - think of cafeteria trays on top of one another.

var websiteStack = new Stack<string>();

//Add a string to websiteStack

websiteStack.Push("www.google.com");
websiteStack.Push("www.bored.com");
websiteStack.Push("www.nationalgeographic.com");

//Find out what's at the top of the string
//Peek doesn't change the stack 
var topOfThStack = websiteStack.Peek();

//Last in first out so "NationalGeographic is going to print
Console.WriteLine(topOfThStack);

//prints  the first element inserted
//Pop changes the stack 
websiteStack.Pop();

topOfThStack = websiteStack.Peek();
Console.WriteLine(topOfThStack);





//Queues 
//Often used in gaming

var queue = new Queue<string>();

queue.Enqueue("Robert");
queue.Enqueue("Dave");
queue.Enqueue("Angelina");
queue.Enqueue("George");


//Queues also have a peek method
var queueString = queue.Peek();
// Console.WriteLine(queueString);


//Dequeue removes who ever is first in line. 
queue.Dequeue();

queueString = queue.Peek();
// Console.WriteLine(queueString);




//LINQ
/* SQL is a type of database that is used. It's 40 years old. 
 * LINQ helps us organize the data in the database. 
 * Stands for Language Integraded Query. 
 * It offers an easy way to access data in in-memory objects. It works quickly as well. 
 * Example: You want to find the user who lives in Florida, Who's favorite team is the Bears, etc. 
 * Gets you very specific information.
 * We will be talking about Method Syntax today 
 * Look up the examples that we can use for LINQ
 */

//Lambda Expressions
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//Below works like a filter where we are  checking for the remainder that is 1. 
int oddNumbers = numbers.Count(n => n % 2 == 1);

var intLists = new List<int>()
          {
              56,
              24,
              23,
              100,
              69,
              45,
              12,
              202

          };

//This will print all of the numbers that are greaterr than 50
//ToList prints all of the numbers greater than 50 
var greaterThanFifty = intLists.Where(x => x > 50).ToList();
Console.WriteLine(string.Join(",", greaterThanFifty));


var greaterThanFifty2 = intLists.Where(x => x > 50 && x < 150).ToList();
Console.WriteLine(string.Join(",", greaterThanFifty2));

var greaterThanFifty3 = intLists.Where(x => x > 50 && x < 150);

//Counts the number of items in the list "8"
Console.WriteLine(intLists.Count());

//If the number in list is true give us a count
var oddNumber = intLists.Count(x => x % 2 == 1);

Console.WriteLine(oddNumber);

var nameList = new List<string>()
            {
                "Bob",
                "Nathaniel",
                "George",
                "Michael",
                "Stephanie",
                "Amy",
                "Joe Bob"
            };

//"Where" pulls the first element of Amy that we find
var findAmy = nameList.Where(x => x == "Amy").First();
Console.WriteLine(findAmy);

//Pulls out "Nathaniel" 
var findAmy2 = nameList.Where(x => x.Contains("th")).First();
Console.WriteLine(findAmy2);

//Complete the Pair Programming Self-Reflection 

