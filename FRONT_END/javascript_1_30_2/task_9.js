function removeGreaterThan(arr,value){
    // let arr1=[];
    // for(let i of arr){
    //     if (i<value){
    //         arr1.push(i);
    //     }
    // }
    // return arr1;

    arr=arr.filter(x=>x<value);
    return arr;
}
let arr=[10,5,20,3,8];
console.log(removeGreaterThan(arr,10));


