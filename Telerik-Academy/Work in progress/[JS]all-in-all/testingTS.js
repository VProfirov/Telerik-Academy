function greeter(person) {
    return "Hello, " + person.firstName + " " + person.lastName + " at " + person.age;
}
// let user = {firstName:"Vas",lastName:"Pro",age:15};
var user = { firstName: "Vas", lastName: "Pro", age: 15 };
console.log(greeter(user));
