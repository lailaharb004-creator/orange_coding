function arrayIntersection(arr1,arr2){
   let arr3=[];

    arr3=arr1.filter(i=>arr2.includes(i));

    return arr3;
}
let arr1=[1,2,3,4];
let arr2=[3,4,5,6];


console.log(arrayIntersection(arr1,arr2));