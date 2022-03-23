// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
//Perimeter = 2l + 2w 
//Area = l* w
Console.WriteLine();

Console.Write("Enter Length: ");
decimal userLength = decimal.Parse(Console.ReadLine());
Console.Write("Enter Width: ");
decimal userWidth = decimal.Parse(Console.ReadLine());

decimal perimeter = (2 * userLength) + (2 * userWidth);
decimal area = userLength * userWidth;

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");

Console.WriteLine();

Console.WriteLine("Thank you for using the Room Detail Generator!");
