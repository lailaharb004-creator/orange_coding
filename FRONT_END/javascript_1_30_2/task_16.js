function wordsLongerThan(arr,length){
    arr=arr.filter(x=>x.length>length);
    return arr;
}

let arr=["alex","mohammad","ali","sara"];
console.log( wordsLongerThan(arr,4));