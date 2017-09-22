let dog = {
	name:'Pesho',
	age: 1
};
let someArr = ['a','b',5.5, dog ];
// let someArr = 'brave new world';

let sA = [...someArr];
console.log(sA);

someArr[2] +=1;
someArr[3].age += 3;
someArr[3].name = 'Gogo';

console.log(someArr);
console.log('-----SA-----');
console.log(sA);

console.log(dog);