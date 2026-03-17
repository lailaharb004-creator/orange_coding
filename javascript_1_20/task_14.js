function functionaddAdult(arr){
     arr.forEach(i=>{i.adult=i.age>=18;});
     return arr;
       
}
let arr=[
 {name:"Ali",age:20},
 {name:"Sara",age:15}
 ];
 console.log(functionaddAdult(arr));
