let num1=Number(prompt("Please enter the first number"));
let num2=Number(prompt("Please enter the second number"));

let operation=prompt("please enter the operation");
let result=0;

if (operation==="+"){
    result=num1+num2;
}
else if (operation ==="-"){
    result=num1-num2;
}
else if (operation ==="*"){
    result=num1*num2;
}
else if (operation ==="/"){
    result=num1/num2;
}

console.log(`The result of ${num1} ${operation} ${num2} = ${result}`);
document.write(`The result of ${num1} ${operation} ${num2} = ${result}`)