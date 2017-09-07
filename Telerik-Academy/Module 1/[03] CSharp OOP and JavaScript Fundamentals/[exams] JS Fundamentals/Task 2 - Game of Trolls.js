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
        Wboup: { r: startsOfUnits[0][0], c: startsOfUnits[0][1], trapped: false },
        Nbslbub: { r: startsOfUnits[1][0], c: startsOfUnits[1][1], trapped: false },
        Lsjtujzbo: { r: startsOfUnits[2][0], c: startsOfUnits[2][1] }
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

    function isInside(r, c) {
        return (0 <= r) && (r < dimensionsOfBoard[0]) && (0 <= c) && (c < dimensionsOfBoard[1]);
    }

    //impure functions func(_,_..)
    function caught() {
        //Math.abs(Wboup.r - Princess.r) <= 1 
        // the distance between Wboup & Princess is 1 or less on the row(r) axis(y)
        let byWboup = (Math.abs(Wboup.r - Princess.r) <= 1) && (Math.abs(Wboup.c - Princess.c) <= 1);
        let byNbslbub = (Math.abs(Nbslbub.r - Princess.r) <= 1) && (Math.abs(Nbslbub.c - Princess.c) <= 1);
        return byWboup || byNbslbub;
    }

    function escaped() {
        return (Wboup.trapped && Nbslbub.trapped) ||
            //The coordinates(r/c) of the princess MATCH the coordinates of the exit
            ((Princess.r === (dimensionsOfBoard[0] - 1)) && (Princess.c === (dimensionsOfBoard[1] - 1)));
        //last row last call
    }

    function onTheSameCell() {
        return (Wboup.r && Nbslbub.r) && (Wboup.c && Nbslbub.c);
    }

    //cut off everything after 2 -included
    let commands = args.slice(2);
    for (var cmd of commands) {
        let cmdSplit = cmd.split(' ');

        if (cmdSplit.first() == 'mv') {
            let direction = directions[cmdSplit.last()]; //[cmdSplit[2]]
            let unit = units[cmdSplit[1]];

            //what allows a unit to move => not trapped and inside the board
            let nextStepR = unit.r + direction.r;
            let nextStepC = unit.c + direction.c;
            if (!unit.trapped && isInside(nextStepR, nextStepC)) {
                unit.r = nextStepR;
                unit.c = nextStepC;

                //check for trap on that location
                let trap = board[unit.r][unit.c];
                if (trap) {
                    //assign trapped => if there is Wboup or Nbslbub already there (a.k.a trapped)
                    if (onTheSameCell()) {
                        //free
                        Wboup.trapped = false;
                        Nbslbub.trapped = false;
                        board[unit.r][unit.c] = false;
                    } else if (unit != Princess) { //not the Princess <->ref(unit) doesn't point to the same obj (ref(Princess)points to)
                        //trap
                        unit.trapped = true;
                    }
                }
            }

        } else if (cmd === 'lay trap') {
            board[Princess.r][Princess.c] = true;
        } else {
            throw Error('Command related Problem');
        }
    }
    //Output

    if (caught()) {
        console.log(`The trolls caught Lsjtujzbo at ${Princess.r} ${Princess.c}`);
        return; // return > break => return ends the function VS break ends the loop (if(!loop) ends func)
    } else if (escaped()) {
        console.log(`Lsjtujzbo is saved! ${Wboup.r} ${Wboup.c} ${Nbslbub.r} ${Nbslbub.c}`);
        return;
    } else {
        throw Error('Problem with the Output');
    }
}

let input = [
    '5 5',
    '1 1;0 1;2 3',
    'mv Lsjtujzbo d',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Wboup r',
    'mv Wboup r',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d'
];
solve(input);