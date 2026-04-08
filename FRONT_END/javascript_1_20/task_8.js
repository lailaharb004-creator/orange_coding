function functionmakeUsernames(arr){
 return arr.map(i =>"@"+i.username)
}
let arr=[{username:"ahmad"},{username:"sara"}];
console.log(functionmakeUsernames(arr));