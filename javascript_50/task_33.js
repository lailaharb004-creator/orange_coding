let str="";
let d1=0;
let d2=0;
let d3=0;

for(let i=1;i<=300;i++){
    str=String(i);
    if(str.length===2){
            d1=Number(str.at(0));
            d2=Number(str.at(1));
            if (d1===d2){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=Number(str.at(0));
        d2=Number(str.at(1));
        d3=Number(str.at(2));
        if(d1===d2 ||d2===d3){
              document.write(i+"<br>");

        }

    }
   
    }