let num=Number(prompt("Please enter any number"));
let result=" ";
let multi=1;
for(i=1; i<=num;i++){
    for(j=1;j<=num;j++){
        multi=i*j;
        result+=`${i} * ${j} = ${multi}\b`;
        
    }
    document.write(result);
    result=" ";
    document.write("<br>");

}