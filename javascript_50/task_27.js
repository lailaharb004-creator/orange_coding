let diff=0;
let str="";
for(let i=1;i<=200;i++){
    str=String(i);
    if(str.length>=2){
        for(let j=1;j<str.length;j++){
            diff=Number(str.at(j));
            diff-=Number(str.at(0))
        }
        if ( diff===2){
            document.write(i+"<br>");
        }
    }
    diff=0;
}