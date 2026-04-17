let str="";
let d1=0;
let d2=0;
let d3=0;
let sum=0;
let multi=1;

for(let i=1;i<=200;i++){
    str=String(i);
    if(str.length===2){
            d1=Number(str.at(0));
            d2=Number(str.at(1));
            sum=d1+d2;
            multi=str.length*5;
            if (sum===multi){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=Number(str.at(0));
        d2=Number(str.at(1));
        d3=Number(str.at(2));
        sum=d1+d2+d3;
        multi=str.length*5
        if(multi===sum){
              document.write(i+"<br>");

        }


    }
    else {
        sum=i;
        multi=str.length*5
        if(multi===sum){
              document.write(i+"<br>");

        }
    }
     multi=1;
     sum=0;

   
    }