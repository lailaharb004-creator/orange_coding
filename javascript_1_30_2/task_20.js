function findShortestWord(arr){
    arr=arr.sort((a,b)=>a.length-b.length);
    return arr[0];

}
let arr=["alex","mohammad","ali","sara"];
console.log(findShortestWord(arr));