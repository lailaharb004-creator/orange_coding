function removeShortWords(arr,length){
    arr=arr.filter(x=>x.length>length);
    return arr;
}

let arr=["apple","banana","car","dog"];
console.log(removeShortWords(arr,4));