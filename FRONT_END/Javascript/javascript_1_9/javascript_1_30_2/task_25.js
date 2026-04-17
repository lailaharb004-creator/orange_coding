function reverseWithoutReverse(arr){
    let arr1=[];
    for (let i of arr){
        arr1.unshift(i);
    }
    return arr1;
}
let arr=[1,2,3,4,5,6];
console.log(reverseWithoutReverse(arr));