function solve(args) {
    let nodes = args[0].split(" ").map(Number);

    let sum = 0;
    let pocket = 0;
    for (var index = 1; index < nodes.length - 1; index++) {

        if (isPeak(index, nodes)) {
            sum += nodes[index];
        }
    }
    console.log(sum);
    // return sum;

    function isPocket(index, nodes) {
        return isPeak(index - 1, nodes) && isValey(index, nodes) && isPeak(index + 1, nodes);
    }

    function isValey(index, nodes) {
        return nodes[index] < nodes[index - 1] && nodes[index] < nodes[index + 1];
    }

    function isPeak(index, nodes) {

    }
}



// solve(["53 20 1 30 2 40 3 10 1"]);
// solve(["53 20 1 30 30 2 40 3 10 1"]);
solve(["53 20 1 30 2 40 3 3 10 1"]);