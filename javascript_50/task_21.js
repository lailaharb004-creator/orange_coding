let sum=0;
let str="";
for(let i=1;i<=200;i++){
    str=String(i);
    for(let j=0;j<str.length;j++){
        sum+=Number(str.at(j));
        
    }
    if(sum===5){
        document.write(i+"<br>");
    }
    sum=0;
}