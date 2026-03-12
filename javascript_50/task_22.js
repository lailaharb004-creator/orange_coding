
let str="";
for(let i=1;i<=100;i++){
    str=String(i);
    
    if(str.at(0)>str.at(str.length-1)){
        document.write(i+"<br>");
    }
    
}