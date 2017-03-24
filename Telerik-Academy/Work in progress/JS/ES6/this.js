let products =[];
let product = {
	manufacturer: 'BMW',
	model: 'x5',
	item: (function () {
		class Car {
			constructor(model, price) {
				this._model = model;
				this._price = price;
			}		
		}
		return new Car('audi', 1001);
	})(),
	price: 100
};
let count = 5;
while(count-->0){
	products.push(product);
}

let options = {
	manufacturerPattern: 'ss',
	modelPattern: 'aa',
	typr: 'car',
	maxPrice: 100,
};

let allFound = products.filter(p => !options.hasOwnProperty('manufacturerPattern') || p.manufacturer.match(options.manufacturerPattern));
	// &&
	// 	(!options.hasOwnProperty('modelPattern') || p.model.match(options.modelPattern)) &&
	// 	(!options.hasOwnProperty('type') || p.item.constructor.name.match(options.type)) &&
	// 	(!options.hasOwnProperty('minPrice') || p.price >= options.minPrice) &&
	// 	(!options.hasOwnProperty('maxPrice') || p.price <= options.maxPrice)) ||'fuck';
// });
console.log(allFound);