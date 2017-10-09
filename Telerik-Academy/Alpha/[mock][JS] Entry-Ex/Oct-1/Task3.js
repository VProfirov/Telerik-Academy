function solve(args) {
    let result = "";
    let checker = "";
    for (let i = 0; i < args[0].length; i++) {
        if (args[0][i] != checker) {
            result += args[0][i];
            checker = args[0][i];
        } else {
            checker = args[0][i];
        }
    }
    console.log(result);
}

solve([
    "Hello"
]);