function printArguments() {
    var i,
        args;

    args = [].slice.apply(arguments);
    for (i in args) {
        console.log(args[i]);
    }

}

printArguments(1, 2, 3, 4);