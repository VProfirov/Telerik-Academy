function solve(args) {
    let number = Number(args[0]);
    let numberOverflowCheck = number < Number.MAX_SAFE_INTEGER - 11;

    let numberAsString = args[0];
    numberAsString = [...numberAsString].reverse();
    let result = [];
    let digit = 0;
    let remainderX10 = 0;
    let counter = 0;

    if (numberOverflowCheck) {
        while (counter++ < 10) {
            console.log(number + counter);
        }
    } else {
        while (counter++ < 10) {
            digit = Number(numberAsString[0]);
            remainderX10 = 0;
            result = [];

            digit += counter;
            if (digit > 9) {
                result.push(digit % 10);
                remainderX10 = 1;
                for (let i = 1; i < numberAsString.length; i++) {
                    digit = Number(numberAsString[i]) + remainderX10;
                    if (digit > 9) {
                        result.push(digit % 10);
                        remainderX10 = 1;
                    } else {
                        result.push(digit);
                        remainderX10 = 0;
                    }
                }
                if (remainderX10) {
                    result.push(1);
                }
            } else {
                result.push(digit);
                for (let i = 1; i < numberAsString.length; i++) {
                    result.push(Number(numberAsString[i]));
                }
            }
            console.log(result.reverse().join(""));
        }
    }
}

solve([
    // "9007199254749992"
    "9999999999999992"
    // "1"
])