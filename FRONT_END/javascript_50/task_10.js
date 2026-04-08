let str1="Orange Coding School";
let str2=str1.toLocaleLowerCase();
let count=0;

for(let i=0;i<=str2.length;i++){
    if (str2.at(i)=="c"){
        count++;
    }
        
}
document.write(count);