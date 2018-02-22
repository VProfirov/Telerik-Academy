function solve(params) {
    let stairs = [params[0], params[1], params[2]];
    let layers = params[3];
    stairs.length = TrNSq(layers);
    stairsFiller(stairs);

    console.log(stairs);

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
        for (let i = 0; i < layers; i++) {

        }
    }
}

solve(
    // [2, 1, 5, 3]
    [3, -2, -1, 4]
);