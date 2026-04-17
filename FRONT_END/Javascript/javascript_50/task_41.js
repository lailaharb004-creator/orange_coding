let str="";
let d1=0;
let d2=0;
let d3=0;
let sum=0;
let multi=1;
for(let i=1;i<=1000;i++){
    str=String(i);
    if(str.length===2){
            d1=Number(str.at(0));
            d2=Number(str.at(1));
            sum=d2+d1;
            multi=d2*d1;
            
            if (sum===multi){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=Number(str.at(0));
        d2=Number(str.at(1));
        d3=Number(str.at(2));
        sum=d1+d2+d3;
        multi=d1*d2*d3;
        
            if (sum===multi){
              document.write(i+"<br>");
            }
        

    }
    sum=0;
    multi=1;

   
    }