let str="";
let d1=0;
let d2=0;
let d3=0;
let multi=1;

for(let i=1;i<=500;i++){
    str=String(i);
    if(str.length===2){
            d1=Number(str.at(0));
            d2=Number(str.at(1));
            multi=d1*d2;
            if (multi%5===0){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=Number(str.at(0));
        d2=Number(str.at(1));
        d3=Number(str.at(2));
        multi=d1*d2*d3;
        if(multi%5===0){
              document.write(i+"<br>");

        }

    }
    else{
        if (i%5===0){
              document.write(i+"<br>");
            }

    }
    multi=1;
   
    }