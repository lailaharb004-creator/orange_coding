let str1="aabbc";

let str2="";

for(let i of str1){
    if (!str2.includes(i)){
        str2+=i;
    }
}

console.log(str2);