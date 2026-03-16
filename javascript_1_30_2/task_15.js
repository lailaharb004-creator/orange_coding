function removeNegativeNumbers(arr){
    return arr.filter(x=>x>0);
}
let arr=[5,-2,10,-3,7];
console.log(removeNegativeNumbers(arr));