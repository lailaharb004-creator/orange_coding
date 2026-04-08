
let num=Number(prompt("Please enter any number"));
let fib=[0,1];
for(let i=2; i<=num;i++){
    fib[i]=fib[i-1]+fib[i-2];
   

   
}
document.write(fib)
