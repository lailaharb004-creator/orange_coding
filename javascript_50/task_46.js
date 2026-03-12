let str="";
let d1=0;
let d2=0;
let d3=0;
let sum="";
for(let i=1;i<=1000;i++){
    str=String(i);
    if(str.length===2){
            d1=Number(str.at(0));
            d2=Number(str.at(1));
            sum=d2+d1;
            
            if (sum*sum===i){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=Number(str.at(0));
        d2=Number(str.at(1));
        d3=Number(str.at(2));
        sum=d1+d2+d3;
        
            if (sum*sum===i){
              document.write(i+"<br>");
            }
        

    }
    else{

        if (i===i*i)
              document.write(i+"<br>");


    }
  
   
    }