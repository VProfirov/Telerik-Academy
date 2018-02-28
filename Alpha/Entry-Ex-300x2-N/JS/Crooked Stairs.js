function solve(params) {
    let bricks = [params[0], params[1], params[2]];
    let layers = params[3];
    bricks.length = TrNSq(layers);
    bricksFiller(bricks);
    // console.log(bricks);
    printer(bricks, layers);

    function bricksFiller(bricks) {
        for (let i = 3; i < bricks.length; i++) {
            bricks[i] = bricks[i - 1] + bricks[i - 2] + bricks[i - 3];
        }
    }

    function TrNSq(num) {
        let result = num * (num + 1) / 2;
        return result;
    }

    function printer(bricks, layers) {
        let position = 0;
        let sizeOfStep = 1;
        for (let layer = 0; layer < layers; layer++) {
            let print = "";
            for (let i = position; i < position + sizeOfStep; i++) {
                print += bricks[i] + " ";
            }
            console.log(print.trim());

            position += sizeOfStep;
            sizeOfStep++;
        }
    }
}

solve(
    // [2, 1, 5, 3]
    [3, -2, -1, 4]
);