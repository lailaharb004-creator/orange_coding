function findSecondSmallest(arr){
   let  arr1=arr.sort((a,b) => a-b);
    return arr1[1];
}
let arr=[4,9,2,10,6];
console.log(findSecondSmallest(arr));