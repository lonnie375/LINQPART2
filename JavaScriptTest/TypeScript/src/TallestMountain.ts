//1. Declare an interface
interface Mountain{
    name: string; 
    height: number; 
}

//2. Declare an array called mountains which is an array of type Mountain 
let mountains:Array<Mountain> = [
    { name: "Kilimanjaro", height: 19341 },
    { name: "Everest", height: 29029}, 
    { name: "Denali", height: 20310 }
]; 

//3. Declare a function called findNameOfTallestMountain 
    //Function will take in an array of mountains
    //It will return a string 
function findNameOfTallestMountain(mountObjects:Array<Mountain>) :string{
        //declare a variable to hold the max height 
        let tallestMountain:number = 0; 
        let tallestName:string = '';
        //Iterate through the mountain 
        for(let i = 0; i < mountObjects.length; i++){
           // mountObjects[i].height
            if(mountObjects[i].height > tallestMountain){
                tallestMountain = mountObjects[i].height; 
                tallestName = mountObjects[i].name; 
            }
        }
        return tallestName; 
        //Look at the height

        //compare the height of the mountain to variable. If grater, then set it to that height. if not, continue

        //return variable that holds max height 
}
//4. Assign the a variable 
let theRealMountain = findNameOfTallestMountain(mountains);

//5. Print the variable 
console.log(theRealMountain);