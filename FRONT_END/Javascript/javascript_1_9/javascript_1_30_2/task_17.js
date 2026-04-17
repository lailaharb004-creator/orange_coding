function countLetterInWords(arr,letter){
     arr=arr.filter(x=>x.includes(letter));
    return arr.length;
}
let arr=["apple","banana","car","dog"];
console.log(countLetterInWords(arr,"a"));