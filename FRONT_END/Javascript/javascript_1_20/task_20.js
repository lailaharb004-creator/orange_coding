function functionisEvenArray(arr){
    return arr.map(i=>{
         if (i%2===0){
            return true;
         }
         else {
            return false;
         }
    }
       
    );
}
let arr=[1,2,3,4];
console.log(functionisEvenArray(arr));