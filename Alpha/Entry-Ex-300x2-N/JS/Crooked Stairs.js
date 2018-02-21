function solve(args) {
    let l1 = [];
    let l2 = [];
    l1[0] = args[0][0];
    l2[0] = args[0][1];
    l2[1] = args[0][2];
    let numberOfLayers = args[0][3];

    let layers = [args[0][0],
        [args[0][1], args[0][2]]
    ];
    console.log(layers);
    layers.length = 5;
    console.log(layers.length);
}

solve(
    [2, 1, 5, 3], [3, -2, -1, 4]
);