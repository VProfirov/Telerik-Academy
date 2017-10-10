function solve(args) {
    let blocks = args[0]
    let blocksArray = [];
    let dumpArray = [];

    for (let i = 0; i < blocks; i += 1) {
        blocksArray.push(i);
    }

    for (let row = 0; row < blocksArray.length; row += 1) {
        dumpArray[row] = [];
        for (let col = 0; col < dumpArray.length; col += 1) {
            dumpArray[row].push(blocksArray.shift());
        }
    }
    let lastArray = dumpArray.length - 1;
    let len = dumpArray[lastArray].length;
    console.log(len);
}

function solveShort(args) {
    console.log(Math.floor((Math.sqrt(8 * args[0] + 1) - 1) / 2));
}
solve([
    "8"
])