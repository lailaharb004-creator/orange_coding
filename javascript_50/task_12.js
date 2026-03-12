let num=1;
let result=""
for(let i=1;i<=5;i++){
    for(let j=1;j<=i;j++){
        result+=num+" ";
        num+=1;
       
    }
 document.write(result+"<br>");
    result=" "
    
}