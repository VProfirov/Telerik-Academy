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
    let args = [];
    for (let i = 0; i < 4; i++) {
        args.push(Number(getParams()));
    }

    let b1 = Number(args[0]);
    let b2 = Number(args[1]);
    let b3 = Number(args[2]);
    let layers = Number(args[3]);

    let triangle = [];
    triangle[0] = [b1];
    triangle[1] = [b2, b3];

    let holder = [b1, b2, b3];
    for (let i = 2; i < layers; i++) {
        let bricksInLayerCounter = i + 1;
        triangle[i] = [];
        for (let brick = 0; brick < bricksInLayerCounter; brick++) {
            triangle[i].push(HolderSum(holder)); //check
            // triangle[i].push(holder.sum());//check
            holder = HolderReSum(holder);
        }
    }

    for (let line of triangle) {
        let sb = line.join(" ") + "\n";
        console.log(sb.trim());
    }

    function HolderReSum(holder) {
        let sum = HolderSum(holder);
        holder[0] = holder[1];
        holder[1] = holder[2];
        holder[2] = sum;
        return holder;
    }

    function HolderSum(holder) {
        let sum = holder[0] + holder[1] + holder[2];
        return sum;
    }
}