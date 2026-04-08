function findMissingNumber(arr){
    arr=arr.sort((a,b)=>a-b);
    for (let i=0;i<arr.length-1;i++ ){
        if (arr[i+1]-arr[i]===2){
            return arr[i]+1;
        }
       
    }
}

let arr=[1,2,3,5,6];
console.log(findMissingNumber(arr));