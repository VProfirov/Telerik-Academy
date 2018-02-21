function solve(args) {
    let strNum = String(args[3]); // single arg
    console.log(strNum); // possible string to integer size problem
    console.log(strNum.length);
    let numberPositive = 0;
    for (let i = 0; i < strNum.length; i++) {
        let target = Number(strNum[i]);
        if (target) {
            numberPositive += target;
        }
    }
    var s = numberPositive;
    if (numberPositive > 9) {
        let result = digitizing(numberPositive);
        console.log(result);
    } else {
        console.log(numberPositive);
    }

    function digitizing(number) {
        let size = String(number).length;
        let result = 0;
        for (let i = 0; i < size; i++) {
            result += number % 10;
            number = Math.floor(number / 10);
        }

        if (result > 9) {
            return digitizing(result);
        } else {
            return result;
        }
    }
}

solve([-7231,
    "1020340567.89",
    "-7231",
    "405671020340567102034056710203405671020340567102034056710203405671020340567102203405671020340567102034056710203405671020340567102034056710203405671020340567102034056710203405671020340567102034056710203405671020340567102030340567102034056710203405671020340567102034056710203034056710203405671020340567.405671020340567102034056710203405671020340567102034056710203405671020340567102203405671020340567102034056710203405671020340567102034056710203405671020340567102034056710203405671020340567102034056710203405671020340567102030340567102034056710203405671020340567102034056710203034056710203405671020340567"
]);