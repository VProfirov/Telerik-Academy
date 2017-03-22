let o = {
	price: 2.1,
	quantity: 11
};
number = 0;
let obj = {
	price:o.price,
	number
};


let price = 5.99, quantity = 10;

let field = 'dynamicField';
let productview = {
	price:7.99,
	quantity: 2,
	[field]:price,
	calculateValue(){
		return this.price*this.quantity;
	}
};

// console.log(productview.calculateValue());
// console.log(productview['dynamicField']);