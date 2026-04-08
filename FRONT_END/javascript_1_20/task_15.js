function functionaddTax(arr){
    let prices=arr.map(i=>i+10);
    return prices;
}
let arr=[100,200];
console.log(functionaddTax(arr));