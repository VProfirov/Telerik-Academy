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

function solve(getParams) {
    let params = [];
    for (let i = 0; i < 4; i++) {
        params.push(Number(getParams()));
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
}