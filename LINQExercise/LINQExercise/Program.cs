// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> reviewIntList = new List<int>()
                {
                    3,
                    15,
                    200,
                    25,
                    1267,
                    489,
                    2,
                    9083,
                    1078983,
                    45,
                    102,
                    356,
                    19783,
                    9053
                };
            //Default value is going to be zero. 
            var lookingForFive = reviewIntList.Where(x => x == 5).FirstOrDefault();

            Console.WriteLine(lookingForFive);

            //How do I get the number of elements in this list using LINQ?

            var count = reviewIntList.Count();
            Console.WriteLine(count);

            //How do I get the sum of all elements

            var countSum = reviewIntList.Sum();
            Console.WriteLine(countSum);

            //How do I get the smallest number?

            var minCount = reviewIntList.Min();
            Console.WriteLine(minCount);

            //How do I get the biggest number?

            var maxCount = reviewIntList.Max();
            Console.WriteLine(maxCount);

            //How do I get the average?

            var avgCount = reviewIntList.Average();
            Console.WriteLine(avgCount);

            //How do I get all numbers between 50 and 500?

            //ToList is used to get all of them
            var rangeNumbers = reviewIntList.Where(x => x >= 50 && x <= 500).ToList();
            Console.WriteLine(String.Join(",", rangeNumbers));



            List<string> nameList = new List<string>()
            {
                "Andy",
                "Bill",
                "Arnold",
                "Keisha",
                "Larry",
                "William",
                "Shanequa",
                "Tyrone",
                "Denise",
                "Vivian",
                "Emily",
                "Jonathan",
                "Cassly",
                "Mergatroid"
            };

            //Testing for null
            var nameIAmSearchingFor = nameList.Where(y => y == "Samantha").FirstOrDefault();
            //null handling

            if (nameIAmSearchingFor == null)
            {

            }

            Console.WriteLine(nameIAmSearchingFor);

            //How do I get the first name in the list that contains "is"?
            var containsIs = nameList.Where(x => x.Contains("is")).First();
            Console.WriteLine(containsIs);

            //How do I alphabetize this list?

            nameList.Sort();
            Console.WriteLine(string.Join(",", nameList));


            //BONUS
            //How do I get the first name that starts with J

            var firstName = nameList.Where(x => x.StartsWith("J")).First();
            Console.WriteLine(firstName);

        }


    }
    /*
    //Have to be fixed set.
    //This is used oftentimes for dropdown list in web development 
    enum HeroType
    {
        Warrior,
        Cleric,
        Mage,
        Warlock,
        Paladin
    }

    enum StoreDepartment
    {
        Electronics,
        Grocery,
        Sporting_Goods,
        Toys
    }
    */

}

