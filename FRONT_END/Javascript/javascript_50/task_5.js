let asc=65;
let row=5;


for(let i=1;i<=5;i++){
    for(let j=1;j<row;j++){
    document.write("A"+" ");
   
    }
     row-=1;
    
    for(let k=1;k<=i;k++){
        document.write(String.fromCharCode(asc)+" ");
    }
    asc+=1;
    
    document.write("<br>")
}