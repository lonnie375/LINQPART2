// See https://aka.ms/new-console-template for more information
//Writing three methods to complete the assignment

//Create a static method name "IsPassing()
//Return a bool
//Takes in a double parameter

 static bool IsPassing(double grade)
{
    if (grade > 65)
    {
        return true;
    }
    else if (grade <= 65)
    {
        return false;
    }
    return true;
}



//Create a static method to average the grades

 static double AverageGrades(double grade1, double grade2, double grade3)
{
    double avgGrade = (grade1 + grade2 + grade3) / 3;
    return avgGrade;
}


//Convert grade to an int and run it through the following conditions
 static string OddOrEvenAndPassing(double grade)
{
    int avgGrade = Convert.ToInt32(grade);

    if (IsPassing(avgGrade) == true && avgGrade % 2 != 0)
    {
        return "passing and odd";
    }
    else if (IsPassing(avgGrade) == false && avgGrade % 2 != 0)
    {
        return "failing and odd";
    }
    else if (IsPassing(avgGrade) == true && avgGrade % 2 == 0)
    {
        return "passing and even";
    }
    else if (IsPassing(avgGrade) == false && avgGrade % 2 == 0)
    {
        return "failing and even";
    }
    return "true";
}

