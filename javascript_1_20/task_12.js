function functioncountEven(arr){
 let count=0;
 arr.forEach(i=>{
    if(i%2===0)
    {
        count++;
    }
})
return count;
}
let arr=[1,2,3,4];
console.log(functioncountEven(arr));