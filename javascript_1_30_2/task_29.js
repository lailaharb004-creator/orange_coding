function chunkArray(arr,size){
    let arr1=[];
    let z=0;
  for (let i=0;i<arr.length/2;i++){
     arr1.push(arr.slice(z,size));
     z=size;
     size+=2;
     
     
  }
  return arr1;
}
let arr=[1,2,3,4,5,6];
console.log(chunkArray(arr,2));