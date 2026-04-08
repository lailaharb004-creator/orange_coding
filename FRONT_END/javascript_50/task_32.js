let str="";
let d1=0;
let d2=0;
let d3=0;
let count=0;

for(let i=1;i<=500;i++){
    str=String(i);
    if(str.length===2){
            d1=Number(str.at(0));
            d2=Number(str.at(1));
            sum=d1+d2;
            for (let j=1;j<=sum;j++){
                if (sum %j===0){
                    count++;
                }
            }
            if (count===2){
              document.write(i+"<br>");
            }
    }
    else if (str.length===3){
        d1=Number(str.at(0));
        d2=Number(str.at(1));
        d3=Number(str.at(2));
        sum=d1+d2+d3;
            for (let j=1;j<=sum;j++){
                if (sum %j==0){
                    count++;
                }
            }
            if (count===2){
              document.write(i+"<br>");
            }

    }
    else{
        for (let j=1;j<=i;j++){
                if (i%j==0){
                    count++;
                }
            }
            if (count===2){
              document.write(i+"<br>");
            }

    }
            count=0;

   
    }