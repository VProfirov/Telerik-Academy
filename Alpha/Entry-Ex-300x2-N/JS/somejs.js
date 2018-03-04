console.log("2050408267460910".length);
console.log("3771288769122467".length);
console.log("6936481483134870".length);

console.log("12758178519718247");
console.log("12758178519718248".length);

console.log("--------------");
console.log(Number.MAX_SAFE_INTEGER);
console.log(Number.MAX_VALUE);
console.log("--------------");

console.log(Number.MAX_SAFE_INTEGER);

console.log(9007199254740992 === (9007199254740993 - 1));

console.log('MIN_VALUE', Number.MIN_VALUE);
console.log('MAX_VALUE', Number.MAX_VALUE);

console.log('MIN_SAFE_INTEGER', Number.MIN_SAFE_INTEGER); //ES6
console.log('MAX_SAFE_INTEGER', Number.MAX_SAFE_INTEGER); //ES6

console.log("--------------");
console.log(Number.MAX_SAFE_INTEGER + 3 + Number.MAX_SAFE_INTEGER + 3);

function addition(a, b, acc = '', carry = 0) {
    if (!(a.length || b.length || carry)) return acc.replace(/^0+/, '');

    carry = carry + (~~a.pop() + ~~b.pop());
    acc = carry % 10 + acc;
    carry = carry > 9;

    return addition(a, b, acc, carry);
}

function sumStrings(a, b) {
    if (a === '0' && b === '0') return '0';
    return addition(a.split(''), b.split(''));
}
console.log("-----------TEST--------");
let result = sumStrings("2050408267460910", "3771288769122467");
console.log(result);
let finalResult = sumStrings(result, "6936481483134870");
console.log(finalResult);

console.log("-----------");
console.log(Number.MAX_SAFE_INTEGER < Number.MAX_VALUE);
console.log(typeof("123123129391293192322" | 1));
console.log(typeof("12758178519718247" | 1));