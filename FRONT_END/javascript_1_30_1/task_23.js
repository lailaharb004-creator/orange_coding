let str="Web development is fascinating";

let str2=str.split(" ");

let long=0;
let index=0
for (let i=0;i<str2.length;i++){
    if (str2[i].length>long){
        long=str2[i].length;
        index=i;
        
    }
}
document.write(str2[index]);
document.write(long);