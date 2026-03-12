
let str="";
let multi=1;
let sum=0;
for (let i=1;i<=300;i++){
    str=String(i);
    if(str.length>=2){
        for(let j=0;j<str.length;j++){
            multi*=Number(str.at(j));
            sum+=Number(str.at(j));
        }
        
        if (multi===sum){
            document.write(i+"<br>");
        }

    }
    sum=0;
    multi=1;
}