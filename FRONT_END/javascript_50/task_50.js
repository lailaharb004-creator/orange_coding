let str="";
let d1=0;
let d2=0;
let d3=0;
let rev="";
let multi=1;

for(let i=1;i<=1000;i++){
    str=String(i);
    if(str.length===2){
            d1=str.at(0);
            d2=str.at(1);
            rev+=d2+d1;
            rev=Number(rev);
            multi=rev*i;
            multi=String(multi);
            if(multi.at(-1)==="1"){
               document.write(i+"<br>");

            }
    }
    else if (str.length===3){
        d1=str.at(0);
        d2=str.at(1);
        d3=str.at(2);
        rev+=d3+d2+d1;
        rev=Number(rev);
        multi=rev*i;
         multi=String(multi);
        if(multi.at(-1)==="1"){
            document.write(i+"<br>");

        }
        

    }
    else{
        rev=i;
        multi=rev*i;
         multi=String(multi);
        if(multi.at(-1)==="1"){
            document.write(i+"<br>");

        }
    }
    multi=1;
   
    rev="";
   
    }