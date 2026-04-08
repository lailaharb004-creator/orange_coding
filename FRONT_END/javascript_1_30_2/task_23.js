function sumEvenNumbers(arr){
    arr=arr.filter(x=>x%2===0).reduce((a,b)=>a+b,0);
    return arr;
}

let arr=[1,2,3,4,5,6];
console.log(sumEvenNumbers(arr));