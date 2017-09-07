function solve(args) {
    Array.prototype.first = function() {
        return this[0];
    };
    Array.prototype.last = function() {
        return this[this.length - 1];
    };

    let dimensionsOfBoard = args[0].split(" ").map(Number);
    let startsOfUnits = args[1].split(";").map(x => x.split(" ").map(Number));
    let units = {
        'Wboup': { r: startsOfUnits[0][0], c: startsOfUnits[0][1] },
        'Nbslbub': { r: startsOfUnits[1][0], c: startsOfUnits[1][1] },
        'Lsjtujzbo': { r: startsOfUnits[2][0], c: startsOfUnits[2][1] }
    }

    let Wboup = units.Wboup;
    let Nbslbub = units.Nbslbub;
    let Princess = units.Lsjtujzbo;
    let directions = {
        l: { r: 0, c: -1 },
        r: { r: 0, c: 1 },
        u: { r: -1, c: 0 },
        d: { r: 1, c: 0 }
    };

    //RESIZABILITY OF ARRAYS
    //only the size of rows is defined by pushing empty arrays, every other row|col is undefined =>
    // trying to access undefined.[], throws error
    let board = [];
    for (var index = 0; index < dimensionsOfBoard[0]; index++) {
        board.push([]);
    }

}