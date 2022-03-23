// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World!");
string firstExampleString = "THIS IS ALL UPPER CASE";
Console.WriteLine(firstExampleString);

//Turn this to lower case
//You have to set it to a new string variable and insert ".ToLower();"
string secondExampleString = firstExampleString.ToLower();

//Test it out
Console.WriteLine(secondExampleString);


//Lets compare two strings
string firstStringToCompare = "The cow jumped over the moon";
string secondStringToCompare = "Another string";

string one = "you love me";
string two = "you love me";

//user String.Compare
//If they are the same it will give you a "0" and if they're different it will give you "1"
var comparison = String.Compare(firstStringToCompare, secondStringToCompare);
var comparison2 = String.Compare(one, two);

// Returns 1 
Console.WriteLine(comparison);

//Returns 0 
Console.WriteLine(comparison2);


//String.Contains

string containerString = "One two three four";
string secondaryString = "Three";

var containsString = containerString.Contains(secondaryString);
Console.WriteLine(containsString); //Returns True 

//String Concatenation
var firstString = "Hello There! ";
var secondString = "How are you today?";
var bString = "You are here with me";
var thirdString = firstString + secondString;
Console.WriteLine(thirdString);

//String.Concat
var fourthString = String.Concat(firstString, secondString, bString);
Console.WriteLine(fourthString);


//String interpolation
var firstName = "John";
var lastName = "Smith";
var fullName = $"Your first name is {firstName} and your last name is {lastName}.";

Console.WriteLine(fullName);

//Substring => WHen you are extracting strings out of strings
string longSentence = "It was the best of times, it was the worst of times.";
string exampleWord = "German Shephard";
Console.WriteLine(exampleWord.Substring(7));
Console.WriteLine(exampleWord.Substring(8));
Console.WriteLine(exampleWord.Substring(7, 8));


