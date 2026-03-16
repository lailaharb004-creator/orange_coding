function pairSum(arr,target){
    let arr1=[]
    for (let i=0;i<arr.length-1;i++){
        if(arr[i]+arr[i+1]===target){
            if (!arr1.includes(arr[i]) && !arr1.includes(arr[i+1])){
                arr1.push(arr[i]);
                arr1.push(arr[i+1])
            }
        }
    }
    return arr1;


}
let arr=[2,7,11,15,1,8];
console.log(pairSum(arr,9));
