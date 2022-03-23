// See https://aka.ms/new-console-template for more information

bool choice = true;
while (choice == true)
{
    Console.Write("Enter a number: ");
    var userInput = Console.ReadLine();
    int end;
    int start = 1;
    bool newInput = int.TryParse(userInput, out end);

    if (newInput)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

    }
    else
    {
        Console.WriteLine("Please enter a number");
        Console.WriteLine();


    }
}
