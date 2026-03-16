function groupByLength(arr){
    let group={};
    for (let i of arr){
        if (!group[i.length]){
            group[i.length]=[];
        }
        
        group[i.length].push(i);
    }
    console.log(group);
}
let arr=["hi","dog","cat","apple"];
 groupByLength(arr)