let str="hello world";
let arr=str.split(" ");

for (let i=0;i<arr.length;i++){
    arr[i]=arr[i].at(0).toUpperCase()+arr[i].substring(1);
}

document.write(arr);