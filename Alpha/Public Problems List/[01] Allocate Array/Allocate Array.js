const line = this.gets;
const print = this.print;

let num = Number(line);
let arr = [];
for (let i = 0; i < num; i++) {
    arr.push(i * 5);
    print(arr[i]);
}