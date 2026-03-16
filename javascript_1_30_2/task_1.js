function firstAndLast(arr){
    let arr1=[];
    arr1[0]=arr[0];
    arr1[1]=arr[arr.length-1];
    return arr1;
}

let arr=[1,2,3,4,5];
console.log(firstAndLast(arr));
