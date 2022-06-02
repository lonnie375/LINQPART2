interface InventoryItem{
    product: Product, 
    quantity: number
}

let inventory:Array<InventoryItem> = [
    {quantity: 10, product:{name: "motor", price: 10},}, 
    {quantity: 12.50, product:{name: "sensor", price: 4},}, 
    {quantity: 1.00, product:{name: "LED", price: 20},}
]

function calcInventoryValue(items:Array<InventoryItem>):number{
    let num = 0; 
    
    for(let i = 0; i <items.length; i++){
    
       num += items[i].product.price * items[i].quantity;
       
    }
    return num; 
}
let test = calcInventoryValue(inventory);
console.log(test);