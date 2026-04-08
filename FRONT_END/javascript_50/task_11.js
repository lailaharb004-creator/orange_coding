let num=Number(prompt("Please enter any number"));
let result="";
let multi=1;
document.write("<pre>");
for(let i=1; i<=num;i++){
    for(let j=1;j<=num;j++){
        multi=i*j;
        result+=`${i} * ${j} = ${multi}`.padEnd(15);
        
    }
    document.write(result);
    result="";
    document.write("<br>");

}
document.write("</pre>");