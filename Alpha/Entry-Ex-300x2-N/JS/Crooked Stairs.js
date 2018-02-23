function solve(params) {
    let stairs = [params[0], params[1], params[2]];
    let layers = params[3];
    stairs.length = TrNSq(layers);
    stairsFiller(stairs);
    // console.log(stairs);
    printer(stairs, layers);

    function stairsFiller(stairs) {
        for (let i = 3; i < stairs.length; i++) {
            stairs[i] = stairs[i - 1] + stairs[i - 2] + stairs[i - 3];
        }
    }

    function TrNSq(num) {
        let result = num * (num + 1) / 2;
        return result;
    }

    function printer(stairs, layers) {
        let position = 0;
        let sizeOfStep = 1;
        for (let layer = 0; layer < layers; layer++) {
            let print = "";
            for (let i = position; i < position + sizeOfStep; i++) {
                print += stairs[i] + " ";
            }
            console.log(print.trim());

            position += sizeOfStep; //FIXME:
            sizeOfStep++;
        }
    }
}

solve(
    // [2, 1, 5, 3]
    [3, -2, -1, 4]
);