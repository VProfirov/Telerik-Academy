function templateProcess(segments,...values){
	console.log(segments);
	console.log(values);

	let a = ' hi', b = 'it is alive';
	return segments[0] + [values[0] + a] + segments[1] + [values[1]+' '+ b];
}
let first = 'first',second = 'sec';
// let template = `Lets see ${first} <= we had, then ${second}`;
// console.log(template); 
// !CANT //  let result = templateProcess template;
// !BREAKS //let result = templateProcess(template);

let result = templateProcess `Lets see ${first} <= we had, then ${second}`;
console.log(result);