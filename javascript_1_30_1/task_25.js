
let str = "mississippi";
let freq={};

for (let i of str){
    if (freq[i]){
        freq[i]+=1;
    }
    else{
        freq[i]=1;
    }
}
console.log(freq);