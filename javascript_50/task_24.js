
let str="";
let multi=1;
for (let i=1;i<=300;i++){
    str=String(i);
    if(str.length>=2){
        for(let j=0;j<str.length;j++){
            multi*=Number(str.at(j));
        }
        if (i%multi===0){
        document.write(i);
       document.write("<br>");

    }

    }
    
    multi=1;
}