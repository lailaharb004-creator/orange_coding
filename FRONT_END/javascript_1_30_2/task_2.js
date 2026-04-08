function removeMiddle(arr){
    if(arr.length%2!==0){
        arr.splice(Math.floor(arr.length/2),1);
    }
    else{
        arr.splice(arr.length/2-1,2)
    }
    return arr;
}
let arr=[1,2,3,4,5,6];
console.log(removeMiddle(arr));