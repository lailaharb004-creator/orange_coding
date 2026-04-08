let str="hello";
let rev="";

for(let i=str.length-1;i>=0;i--){
    rev+=str.at(i);
}

document.write(rev);
console.log(rev);