let num=1;
let row=5;


for(let i=1;i<=5;i++){
    for(let j=1;j<row;j++){
    document.write(1+" ");
   
    }
     row-=1;
    
    for(let k=1;k<=i;k++){
        document.write(num+" ");
    }
    num+=1;
    
    document.write("<br>")
}