let age=Number(prompt("Please enter your age"));
let result=""

if(age <13){
    result="Child";
}
else if (age >=13 && age <=19){
    result="Teenager";
}
else if (age >=20 && age <=59){
    result="Adult";
}
else {
    result="Senior";
}

alert(`You are an ${result}`);
console.log(`You are an ${result}`);
