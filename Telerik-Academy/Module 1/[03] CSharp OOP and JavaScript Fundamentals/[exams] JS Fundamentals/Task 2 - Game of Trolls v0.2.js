function solve() {
    const sizes = args[0].split(' ');
    const field = [];
    for (var index = 0; index < sizes[0]; index++) {
        field.push([]);
    }

    const startingPositions = args[1].split(';').map(x => x.split(' ').map(Number));
    const units = {
        Wboup: { r: [0][0], c: [0][1], trapped: false },
        Nbslbub: { r: [1][0], c: [1][1], trapped: false },
        Lsjtujzbo: { r: [2][0], c: [2][1] }
    };

    const troll_1 = units.Wboup;
    const troll_2 = units.Nbslbub;
    const princess = unit.Lsjtujzbo;

    const moves = {
        l: { r: 0, c: 1 },
        r: { r: 0, c: -1 },
        u: { r: -1, c: 0 },
        d: { r: 1, c: 0 }
    };
    //rules
    function isCaught() {
        const t1 = (Math.abs(troll_1.r - princess.r) <= 1) && (Math.abs(troll_1.c - princess.c) <= 1);
        const t2 = (Math.abs(troll_2.r - princess.r) <= 1) && (Math.abs(troll_2.c - princess.c) <= 1);
        return t1 || t2;
    }

    function isEscaped() {
        const checked = (princess.r == (sizes[0] - 1)) && (princess.c == (sizes[1] - 1));
        return checked;
    }

    function isOnField(r, c) {
        const checked = (((r > 0) && (r < (sizes[0] - 1))) && ((c > 0) && (c < (sizes[1] - 1))));
        return checked;
    }

    function isTrollsTogether() {
        const checked = (troll_1.r == troll_2.r) && (troll_1.c == troll_2.c);
        return checked;
    }
    //commands
    const commands = args.slice(2);
    for (const cmd of commands) {
        let subCMD = cmd.split(' ');
        let unit = units[subCMD[1]];

        if (subCMD[0] == 'mv') {
            const nextR = unit.r + subCMD[2];
            const nextC = unit.c + subCMD[2];
            if (isOnField(nextR, nextC)) {
                unit.r = nextR;
                unit.c = nextC;

            }

        } else if (cmd == 'lay a trap') {
            field[princess.r][princess.c] = true;
        } else {
            throw Error('Commands Problem');
        }
    }
}