// See https://aka.ms/new-console-template for more information
//The first for loop is where you dictate the number of rows you will need
//The second for loop determines what is going to be printed on each row and how many times.
//We are printing the asterisk on each line and printing that number of asterisks.
//"\n" is used to print a new line

int rows = 10;

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    Console.Write("\n");
}
