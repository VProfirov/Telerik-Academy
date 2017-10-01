function solve(arg) {
    let number = Number(arg[0]);
    let avg = 5;
    let result = Math.round(number / avg);
    console.log(result);
}
solve(["17"]);
// solve(["17 2 3"]);

// {
//     console.log(typeof(number) + " is " + number);
//     let n = arg[0].split(" ").map(Number);
//     for (let i of n) { console.log(i + " " + typeof(i)); }
// }