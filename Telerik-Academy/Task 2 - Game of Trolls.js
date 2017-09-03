function solve(args) {
    var gameboardSize = args[0].split(" ").map(Number);
    var gameboard = new Array(gameboardSize[0]);
    for (let arr of gameboard) {
        arr = new Array(gameboardSize[1]);
    }

    PrintGameBoard(gameboard);

    function PrintGameBoard(gameboard) {
        for (let row of gameboard) {
            row = "r";
            for (let col of row) {
                // console.log(col);
                console.log("X");
            }
        }
    }
}

solve("5 5");