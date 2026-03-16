function countOccurrences(arr,value){
    arr=arr.filter(x=>x===2);
    return arr.length;
}
console.log(countOccurrences([1,2,3,2,4,2],2));