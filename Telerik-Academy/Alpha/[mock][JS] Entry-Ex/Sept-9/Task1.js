function solve(args) {
    let number = Number(args[0]);
    let counter = 0;
    while (counter++ < 10) {
        console.log(number + counter);
    }
}

solve([
    "90"
])