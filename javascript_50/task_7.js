let num=1;

for(let i=1;i<=5;i++){
    for(let j=1;j<=5;j++){
        if (i===j){
            document.write(num+" ");
            num+=1
            
        }
        else{
        document.write(0+" ");
        }
    }
    document.write("<br>");
}