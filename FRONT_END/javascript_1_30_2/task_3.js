function swapFirstLast(arr){
    let f=arr[0];
    let l=arr[arr.length-1];
    

    arr[0]=l;
    arr[arr.length-1]=f;

    return arr;
}

let arr=[1,2,3,4,5];
console.log(swapFirstLast(arr));