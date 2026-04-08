let str="";
let d1=0;
let d2=0;

let seq="";
for(let i=1;i<=1000;i++){
    
    str=String(i*i);
    if(str.length>2){
        d1=str.at(-2);
        d2=str.at(-1);
        seq+=d1+d2;
        seq=Number(seq);
        if (seq===i){
            document.write(i+"<br>");
        }
    }
    else if (str.length<=2){
        d1=Number(str.at(-1));
        if (d1===i){
         document.write(i+"<br>");
        }
   
    }
    seq="";

}