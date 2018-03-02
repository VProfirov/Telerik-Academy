const getGets = (arr) => {
    let index = 0;

    return () => {
        const toReturn = arr[index];
        index += 1;
        return toReturn;
    };
};
const test = [
    // [2, 7, 4, 12, 6, 4, 4]
    // "2 7 4 12 6 4 4"
    "-7 2 4 13 6 -12 8"
];
const gets = this.gets || getGets(test);
const print = this.print || console.log;
solve(gets);

function solve(getParams) {
    let arg = getParams();
    let arr = arg.split(' ').map(Number);
    // console.log(arr);
    let distance = 0;
    let sumEvenDistances = 0;
    for (let i = 0; i < arr.length - 1; i++) {
        distance = Math.abs(arr[i] - arr[i + 1]);
        if (distance % 2 == 0) {
            sumEvenDistances += distance;
            i += 1;
        }
    }
    // console.log(distances);
    print(sumEvenDistances);
}