var matrix = [];
matrix.push(["1", "2"]);
matrix.push(["1", "2"]);
matrix.push(["1", "2"]);

// //GG - Printed by column by column
// // col |/| row => colCell |/| rowCell
// for (var col = 0; col < matrix[col].length; col++) {
//     var rows = "";
//     console.log("Column " + col);
//     for (var row = 0; row < matrix.length; row++) {
//         // console.log(matrix[col][row]);
//         rows += matrix[row][col];
//     }
//     //Printing an entire column
//     console.log(rows);
// }


////GG - Printed by row by row
// for (var row = 0; row < matrix.length; row++) {
//     var columns = "";
//     console.log("Row " + row);
//     for (var col = 0; col < matrix[row].length; col++) {
//         // all columns for row 
//         columns += matrix[row][col];
//     }
////Printing an entire row
//     console.log(columns);
// }

var cube = [];
cube.push(["1", "2"], ["3", "4"]);
cube.push(["1", "2"], ["3", "4"]);
cube.push(["1", "2"], ["3", "4"]);

//experiment 1
// for (var col = 0; col < cube[col].length; col++) {
//     var rows = "";
//     console.log("Column " + col);
//     for (var row = 0; row < cube.length; row++) {
//         // console.log(cube[col][row]);
//         rows += cube[row][col];
//     }
//     //Printing an entire column
//     console.log(rows);
// }
//output sample :
// Column 0
// 131313
// Column 1
// 242424

//experiment 2 
// for (var row = 0; row < cube.length; row++) {
//     var columns = "";
//     console.log("Row " + row);
//     for (var col = 0; col < cube[row].length; col++) {
//         // all columns for row 
//         columns += cube[row][col];
//     }
//     //Printing an entire row
//     console.log(columns);
// }
//output sample :
// Row 0
// 12
// Row 1
// 34
// Row 2
// 12
// Row 3

let seq = "";
for (var z = 0; z < cube.length; z++) {
    ////in sequence 12 | 34 -> Z
    // var seq = "";
    for (var y = 0; y < cube[y].length; y++) {
        for (var x = 0; x < cube[y][x].length; x++) {
            seq += cube[z][y][x];
        }
        console.log(seq);

    }

}