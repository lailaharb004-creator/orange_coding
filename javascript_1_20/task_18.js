function functionproductNames(arr){
    return arr.map(i=>i.product);
}
let arr=[
 {product:"Laptop",price:1000},
 {product:"Phone",price:500}
 ]
 console.log(functionproductNames(arr));