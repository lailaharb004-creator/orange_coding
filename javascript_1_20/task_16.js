function functioncountBig(arr){
let count=0;
arr.forEach(i=>
    {
    if(i>50){count++;
    }});
return count;
}
let arr=[20,60,80];
console.log(functioncountBig(arr));