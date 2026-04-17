function sortByLength(arr){
    arr=arr.sort((a,b)=>a.length-b.length);
    return arr;
}
let arr=["apple","hi","banana"];
console.log(sortByLength(arr));
