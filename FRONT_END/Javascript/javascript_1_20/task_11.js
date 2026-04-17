function functionsumNumbers(arr){
     let sum=0;
     arr.forEach(i=>sum+=i);
     return sum;
}
let arr=[10,20,30];
console.log(functionsumNumbers(arr));