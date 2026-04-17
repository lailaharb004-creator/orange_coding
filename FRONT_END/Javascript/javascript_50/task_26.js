let str="";

let str1="";
for(let i=1;i<=500;i++){
    str=String(i);
    
    for(let j=str.length-1;j>=0;j--)
        str1+=str.at(j);
        str1=Number(str1);
     if(str1%3===0 && i%3===0){
        document.write(i+"<br>")
     }

    
    str1="";

}