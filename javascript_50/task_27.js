let diff=0;
let str="";
for(let i=1;i<=200;i++){
    str=String(i);
    if(str.length>=2){
        diff=str.at(str.length-1);
        for(let j=0;j<str.length-1;j++){
            diff-=Number(str.at(j));
        }
        if ( diff===2 ){
            document.write(i+"<br>");
        }
    }
    diff=0;
}