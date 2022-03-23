// See https://aka.ms/new-console-template for more information

//Creating an instance
var newDog = new Class_1Dog();

//Lets be specific about the characteristics of our dog
newDog.Breed = "Pitbull";
newDog.Age = 56;
newDog.Name = "Simba";
newDog.Weight = 45.00;

//Second dog characteristics
var secondDog = new Class_1Dog();
secondDog.Breed = "Great Dane";
secondDog.Age = 7;
secondDog.Name = "Blue";
secondDog.Weight = 50;

//Third dog
var thirdDog = new Class_1Dog();
secondDog.Breed = "Lab";
secondDog.Age = 2;
secondDog.Name = "Fido";
secondDog.Weight = 65;

//prints out simba
Console.WriteLine(newDog.Name);

Console.WriteLine(secondDog.Name);


//Applying the method to the instance of dog. 
Console.WriteLine(newDog.Bark());



//Creating a list of the dogs in our dog class "Class_1Dog 
List<Class_1Dog> dogList = new List<Class_1Dog>();

dogList.Add(newDog);
dogList.Add(secondDog);
dogList.Add(thirdDog);

//We can also do this to add to our list. THis line adds the name, age, breed, and size
dogList.Add(new Class_1Dog() { Name = "Simba", Age = 2, Breed = "German Shephard", Size = "Medium" });

//Can also use
List<Class_1Dog> secondDogList = new List<Class_1Dog>()
            {
                new Class_1Dog() { Name = "Fido", Size = "Small"},
                new Class_1Dog() { Name = "Sham", Size = "Large"},
            };

//Foreach loops with classes
foreach (Class_1Dog dog in dogList)
{
    Console.WriteLine(dog.Name);
}

//We can use linq
Console.WriteLine("Give me the name of your dog and I'll see if its in the list.");
var userInput = Console.ReadLine();
var dogToFind = dogList.Where(x => x.Name == userInput).FirstOrDefault();

if (dogToFind == null)
{
    Console.WriteLine("I'm sorry we don't have that dog");
}
else
{
    Console.WriteLine("Yup, we have that dog");
}




