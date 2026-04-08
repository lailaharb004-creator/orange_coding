let str1="listen";
let str2="silent";

let flag=str1.split("").sort().join("")===str2.split("").sort().join("");
console.log(flag);
