function removeGreaterThan(arr,value){

    arr=arr.filter(x=>x>=value);
    return arr;
}
let arr=[10,5,20,3,8];
console.log(removeGreaterThan(arr,10));

