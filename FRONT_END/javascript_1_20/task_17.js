function functionlabelNumbers(arr){
    return arr.map(i=>({
        Number:i
    }));
   
}
let arr=[5,10];
console.log( functionlabelNumbers(arr));