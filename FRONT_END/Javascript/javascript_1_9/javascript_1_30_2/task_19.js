function findLongestWord(arr){
    arr=arr.sort((a,b)=>b.length-a.length );
    return arr[0];

}
let arr=["apple","banana","car","dog"];
console.log(findLongestWord(arr));