// See https://aka.ms/new-console-template for more information
int spaces = 10;
int asterix = 1;
//This is the website where I found this solution. This has been the only exercise that I have completed where I wasn't able to get the
//solution my self.https://forum.tutorials7.com/1087/how-to-create-a-christmas-tree-in-c%23 
//The first for loop controls the number of times the loop is going to be ran. Starting at zero and increasing by 1 each time. 
for (int i = 0; i < 10; i++)
{
    //This has to represent the number of spaces in between the asterisks? 0 - 9 THrough each loop another space will be added? 
    for (int j = 0; j < spaces; j++)
    {
        Console.Write(" ");
    }
    //This for loop adds an  asterik and a space? 
    for (int j = 0; j < asterix; j++)
    {
        Console.Write("* ");
    }

    //Skips a line time the main loop is ran. 
    Console.WriteLine();
    //Through each iteration we will add asterix and remove a space. 
    asterix++;
    spaces--;
}
