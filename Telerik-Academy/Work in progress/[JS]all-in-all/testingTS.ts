interface Person{
    firstName: string;
    lastName: string;
    age:Int32Array;
}

function greeter(person:Person) {
    return "Hello, " + person.firstName + " " + person.lastName + " at " + person.age;
}
// let user = {firstName:"Vas",lastName:"Pro",age:15};
var user = {firstName:"Vas",lastName:"Pro",age:15};
console.log(greeter(user));