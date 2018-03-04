const getGets = (arr) => {
    let index = 0;

    return () => {
        const toReturn = arr[index];
        index += 1;
        return toReturn;
    };
};
const test = [
    1, 2, 7, 11
    //2, 1, 5, 3
    // 3, -2, -1, 4
];
const gets = this.gets || getGets(test);
const print = this.print || console.log;
solve(gets);
quit(0);

function solve(getParams) {
    let params = [];
    for (let i = 0; i < 4; i++) {
        params.push(parseFloat(getParams()));
    }

    let bricks = [params[0], params[1], params[2]];
    let layers = params[3];
    bricks.length = TrNSq(layers);
    bricksFiller(bricks);
    // console.log(bricks);
    builder(bricks, layers);

    function bricksFiller(bricks) {
        for (let i = 3; i < bricks.length; i++) {
            bricks[i] = bricks[i - 1] + bricks[i - 2] + bricks[i - 3];
            if (!Number.isSafeInteger(bricks[i])) {
                bricks[i] = sumStrings(bricks[i - 1].toString(), sumStrings(bricks[i - 2].toString(), bricks[i - 3].toString()));
            }
        }
    }

    function TrNSq(num) {
        let result = num * (num + 1) / 2;
        return result;
    }

    function builder(bricks, layers) {
        let position = 0;
        let sizeOfStep = 1;
        for (let layer = 0; layer < layers; layer++) {
            let buildingFloor = "";
            for (let i = position; i < position + sizeOfStep; i++) {
                buildingFloor += bricks[i] + " ";
            }
            print(buildingFloor.trim());
            position += sizeOfStep;
            sizeOfStep++;
        }
    }

    function addition(a, b, acc = '', carry = 0) {
        if (!(a.length || b.length || carry)) return acc.replace(/^0+/, '');

        carry = carry + (~~a.pop() + ~~b.pop());
        acc = carry % 10 + acc;
        carry = carry > 9;

        return addition(a, b, acc, carry);
    }

    function sumStrings(a, b) {
        if (a === '0' && b === '0') return '0';
        return addition(a.split(''), b.split(''));
    }
}