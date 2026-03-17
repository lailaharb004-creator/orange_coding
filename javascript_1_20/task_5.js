function functiongetNames(arr){
   return arr.map(i=>i.get("name"));
}

const arr=[
new Map ([["name","Ali"],["age",20]]),
new Map([["name","Sara"],["age",25]])



];

console.log(functiongetNames(arr))