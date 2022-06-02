//This is used to determine the type something is 
let thisIsANumber:number = 50; 

let thisIsAString:string = 'Hello'; 

let thisIsABoolean:boolean = true; 

//Because we inserted ":number" you can't recreate the variable as a string. 
//thisIsANumber = '500';

//Allows it to be any 
let specialType:any = 'whatever';

//Sets it as a string 
let specialCase = 'Now'; 

//Methods are called functions in JavaScript
//This method accepts age as a number and returns a boolean
//Don't use 'any' with a parameter 
function canStudentDrive(age:number) : boolean{
    if(age >=16){
        return true; 
    }
    else{
        return false; 
    }
    
}

let canDrive = canStudentDrive(20);

//This is nothing like C#
//This is more like a class
//You have the property and then you have the data type 
interface Student{
    name:string; 
    age:number; 
    canDrive:boolean
}

let studentArray:Array<Student> = [
    { name: "Bob", age: 10, canDrive: true },
    { name: "Ryan", age: 110, canDrive: false },
    { name: "Thomas", age: 2, canDrive: true }
]

studentArray.push({ name: "Shawn", age: 22, canDrive: false}); 

console.log(studentArray); 
console.log(studentArray.length); 

//This will grab the first element in the array just like in C#
let firstItemInArray = studentArray[0]; 
console.log(firstItemInArray); 
