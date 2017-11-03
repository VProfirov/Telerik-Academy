var animals = [
    { species: 'Lion', name: 'King' },
    { species: 'Whale', name: 'Fail' }
];

for (var i = 0; i < animals.length; i++) {
    (function(i) {
        this.print = function() {
            console.log('#' + i + ' ' + this.species +
                ': ' + this.name);
        }
        this.print();
    }).call(animals[i], i);
}

// function solve(args) {
//     args.forEach(function(element) {
//         element += 1;
//     }, this);


// }

// solve([
//     "asd", 5, "333"
// ]);