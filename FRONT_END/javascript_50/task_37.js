let str="";
let d1=0;
let d2=0;
let d3=0;
let rev="";
for(let i=1;i<=500;i++){
    str=String(i);
    if(str.length===2){
            d1=str.at(0);
            d2=str.at(1);
            rev+=d2+d1;
            rev=Number(rev);
            if (rev%2===0){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=str.at(0);
        d2=str.at(1);
        d3=str.at(2);
        rev+=d3+d2+d1;
            rev=Number(rev);
            if (rev%2===0){
              document.write(i+"<br>");
            }
        

    }
    else{
        if(i%2===0){
              document.write(i+"<br>");

        }
    }
    rev="";
   
    }