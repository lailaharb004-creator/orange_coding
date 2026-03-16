 function findSecondLargest(arr){
    let arr1=arr.sort((a,b) => b - a);
    console.log(arr1);
    return arr1[1];
 }

let arr=[4,9,2,10,6];
console.log(findSecondLargest(arr));