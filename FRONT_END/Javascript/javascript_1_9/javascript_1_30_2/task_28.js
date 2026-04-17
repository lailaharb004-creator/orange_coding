function rotateArray(arr,steps){
    let arr1=arr.slice(-steps);
    let arr2=arr.slice(0,arr.length-steps);
    arr=arr1.concat(arr2);
    console.log(arr1);
    console.log(arr2);
    return arr;

}

let arr=[1,2,3,4,5,6];
console.log(rotateArray(arr,2));