let str="A man, a plan, a canal, Panama!";

let arr=str.match(/[a-zA-z]/g).join("").toLowerCase();

let rev="";
for(let i of arr){
    rev+=i;
}
if (arr===rev){
    document.write(true);
}
else{
    document.write(false);

}
console.log(arr);

