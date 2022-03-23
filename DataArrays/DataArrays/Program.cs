// See https://aka.ms/new-console-template for more information
//Array 

    
    //This creates a new array with 3 elements
    // The word "new" instantiates things

   int[] intArray = new int[3] { 1, 2, 3 };

    //indexOf tells you the index of what ever you insert
    //If what you requests is not in the array it will give you a -1. 
    var indexOfElement = Array.IndexOf(intArray, 3);
    Console.WriteLine(indexOfElement);

    //COntains is a common method that we use
    //You simply get a true or false whether or not the array contains what information you are asking or inserting 
    bool containsInt = intArray.Contains(3);
    bool containsInt2 = intArray.Contains(1000);
    Console.WriteLine(containsInt);
    Console.WriteLine(containsInt2);

    


    //How to get the value out of the index? This is below
    var zeroIndex = intArray[0];
    Console.WriteLine(zeroIndex);

    intArray[2] = 100;

    Console.WriteLine(intArray);

    string[] stringArray = new string[] { "Banana", "Orange", "Grapefruit" };

    double[] doubleArray = new double[] { 4.5, 10.5 };



    
    //You can also loop through the array 
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.WriteLine(intArray[i]); 
    }
    

    
    int sum = 0;

    for (int i = 0; i < intArray.Length; i++)
    {

        Console.WriteLine(i);
    }


    //foreach loop
    foreach (int i in intArray)
    {
        Console.WriteLine(i);
    }
    

    
    //Notice that the for loop gives the index of the value while the foreach loop gives the actual value of the index
    //Foreach loops are only when you want to do something with the object
    //for loop is for when you want the index value 
    //string[] stringArray = new string[] { "Banana", "Orange", "Grapefruit" };

    foreach (string next in stringArray)
    {

        Console.WriteLine(next);
    }
    


    int[] intArray1 = new int[5] { 2, 8, 9, 24, 51 };


    var blah = Array.IndexOf(intArray1, 5);
    Array.Sort(intArray1);
    Console.WriteLine(string.Join(",", intArray1));


            //Clear sets it to it's default value as well. 
            //Sort arranges them from highest to lowest 


