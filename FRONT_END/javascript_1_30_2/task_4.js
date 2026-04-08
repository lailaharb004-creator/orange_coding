function insertAtMiddle(arr,value){
    if (arr.length%2===0){
        arr.splice(arr.length/2,0,value);
    }
    else{
        arr.splice(Math.floor(arr.length/2),0,value);

    }
    return arr;
}

let arr=[1,2,3,4];
console.log(insertAtMiddle(arr,10));