// See https://aka.ms/new-console-template for more information

using LINQPart2;
using OpenXmlPowerTools;
using System.Linq;

//Instantiate a new Student Class 
List<StudentClass> classList = new List<StudentClass>()
{ 
//Make new instances of the Student Class list 
new StudentClass() { Name = "Jimmy", Age = 13 },
new StudentClass() { Name = "Hannah", Age = 21 },
new StudentClass() { Name = "Justin", Age = 30 },
new StudentClass() { Name = "Sarah", Age = 53 },
new StudentClass() { Name = "Hannibal", Age = 15 },
new StudentClass() { Name = "Phillip", Age = 16 },
new StudentClass() { Name = "Maria", Age = 63 },
new StudentClass() { Name = "Abe", Age = 33 },
new StudentClass() { Name = "Curtis", Age = 10 }
};

//Find all students age of 21 and over: Hannah, Justin, Sarah, Maria, Abe, 

var stuAgeOver = classList.Where(x => x.Age >= 21).ToList();
    foreach(var age in stuAgeOver)
{
    Console.WriteLine(age.Name);
}


//Find the oldest student: Maria 
var oldStudent = classList.Max(x => x.Age); 

var studentName = classList.Where(x => x.Age == oldStudent).FirstOrDefault();
Console.WriteLine(studentName.Name);

//Find the youngest student: Curtis 
var youngStudent = classList.Min(a => a.Age);
var youngestStu = classList.Where(a => a.Age == youngStudent).FirstOrDefault();
Console.WriteLine(youngestStu.Name);

//Find the oldest student under the age of 25: Hannah 
var closest = classList.TakeWhile(x => x.Age < 25).Last();
Console.WriteLine(closest.Name);


//Find all students over 21 and with even ages: Justin
var studentVerify = classList.Where(x => x.Age > 21).Where(x => x.Age % 2 == 0).FirstOrDefault();
Console.WriteLine(string.Join(",", studentVerify.Name));

//Find all teenage students (13 to 19 inclusive): Jimmy, Hannibal, Phillip 
var ageRange = classList.Where(x => x.Age >= 13 && x.Age <= 19).ToList(); 
foreach (var age in ageRange)
{
    Console.WriteLine(age.Name); 
}

// Find all students who name starts with a vowel
var listVowels = new List<string>() { "A", "E", "I", "O", "U" };

var list = classList.Where(x => listVowels.Contains(x.Name[0].ToString())).ToList(); 

foreach(var cast in list)
{
    Console.WriteLine(cast.Name);
}