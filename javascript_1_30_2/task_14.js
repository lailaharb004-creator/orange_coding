function uniqueMerge(arr1,arr2){
    let arr3=arr1.concat(arr2);
    let arr4=[];
    for(let i of arr3){
        if(!arr4.includes(i)){
            arr4.push(i);
        }
    }
    return arr4;

}
let arr1=[1,2,3];
let arr2=[3,4,5];
console.log(uniqueMerge(arr1,arr2));