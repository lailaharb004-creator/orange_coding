function removeEverySecond(arr){
    arr=arr.filter(x=>arr.indexOf(x)%2===0);
    return arr;
}

let arr=[1,2,3,4,5];
console.log( removeEverySecond(arr));