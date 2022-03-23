// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
//Perimeter = 2l + 2w 
//Area = l* w
//Volume = l * w * h
Console.WriteLine();

Console.Write("Enter Length: ");
decimal userLength = decimal.Parse(Console.ReadLine());
Console.Write("Enter Width: ");
decimal userWidth = decimal.Parse(Console.ReadLine());
Console.Write("Enter height: ");
decimal userHeight = decimal.Parse(Console.ReadLine());


decimal perimeter = (2 * userLength) + (2 * userWidth);
decimal area = userLength * userWidth;
decimal volume = userLength * userWidth * userHeight;
decimal surfaceArea = 2 * (userLength * userWidth + userWidth * userHeight + userLength * userHeight);

Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface Area: {surfaceArea}");

Console.WriteLine();

if (area <= 250)
{
    Console.WriteLine($"The room is {area} square feet and is considered to be a small room.");
}
if (area > 250 && area < 650)
{
    Console.WriteLine($"The room is {area} square feet and is considered to be a medium sized room.");
}
if (area >= 650)
{
    Console.WriteLine($"The room is {area} square feet and is considered to be a large room.");
}
Console.WriteLine();
Console.WriteLine("Thank you for using the Room Detail Generator!");