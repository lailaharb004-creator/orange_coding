function arrayDifference(arr1,arr2){
    let arr3=arr1.filter(x=>!arr2.includes(x));
    return arr3;
}
let arr1=[1,2,3,4];
let arr2=[3,4,5,6];
console.log(arrayDifference(arr1,arr2));