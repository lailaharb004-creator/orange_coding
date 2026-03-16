let str="racecar";
let rev="";
for(let i=str.length-1;i>=0;i--){
    rev+=str.at(i);
}
if (str===rev){
    document.write(true);
}
else{
    document.write(false);

}