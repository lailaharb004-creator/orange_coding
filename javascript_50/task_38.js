let str="";
let d1=0;
let d2=0;
let d3=0;
let seq="";
for(let i=1;i<=300;i++){
    str=String(i);
    if(str.length===2){
            d1=Number(str.at(0));
            d2=Number(str.at(1));
            seq=d2*d2;
            
            if (seq===d1){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=Number(str.at(0));
        d2=Number(str.at(1));
        d3=Number(str.at(2));
        seq=d3*d3*d3;
        
            if (seq===d1){
              document.write(i+"<br>");
            }
        

    }
    else{

        if (i*i===i)
              document.write(i+"<br>");


    }
  
   
    }