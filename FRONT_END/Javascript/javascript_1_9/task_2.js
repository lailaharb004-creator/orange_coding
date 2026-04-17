let mark=Number(prompt("please enter the mark"));
let result=""
if (mark<50){
    result="F";
}
else if (mark >=50 && mark <=59){
    result="D";
}
else if (mark >=60 && mark<=69){
    result="C";
}
else if (mark>=70 && mark <=79 ){
    result="B";
}
else if ( mark >=80 && mark<=89){
    result="A";
}
else if (mark >=90 && mark<=100){
    result="A+";
}

document.write(`The result for ${mark} is ${result}`)