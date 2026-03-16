function removeDuplicates(arr){
    let arr1=[];
    for (let i of arr){
        if (!arr1.includes(i)){
            arr1.push(i);
        }
    }
    return arr1;
}



let arr=[1,2,2,3,4,4,5,6];
console.log(removeDuplicates(arr));