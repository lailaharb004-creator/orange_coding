function functionvalTimesIndex(arr) {
    return arr.map(i => i * arr.indexOf(i));
}
let arr = [2, 3, 4];
console.log(functionvalTimesIndex(arr));