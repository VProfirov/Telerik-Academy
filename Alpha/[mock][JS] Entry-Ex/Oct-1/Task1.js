function solve(args) {
    let result = 0;
    for (let i = 0; i < args.length; i++) {
        if ((Number(args[i][0]) + Number(args[i][2])) === Number(args[i][1])) {
            result += Number(args[i]);
        }
    }
    console.log(result);
}