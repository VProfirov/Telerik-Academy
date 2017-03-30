function solve() {
    // Your classes
	const VALIDATOR = {
		validateSTRING(str, minLen, maxLen) {
			if (typeof str != 'string' || str.length < minLen || str.length > maxLen) {
				throw Error(`${str} is not valid string between ${minLen}-${maxLen}`);
			}
		},
		validateQUALITY(quality) {
			if (typeof quality != 'string' || !quality.match(/^(high|mid|low)$/)) {
				throw Error(`(${quality}) is not valid quality(hight, mid or low)`);
			}
		},
		validatePositiveNonZeroNUMBER(number) {
			if (typeof number != 'number' || number < 0 || Number.isNaN(number)) {
				throw Error(`${number} is not positive non zero number`);
			}
		},
		validatePositiveNonZeroINTEGER(integer) {
			if (typeof integer != 'number' || (integer >>> 0 !== parseFloat(integer))) {
				throw Error(`${integer} is not positive non zero integer`);
			}
		},
		validateNUMBERinRANGE(number, min, max) {
			if (typeof number != 'number' || number < min || number > max || Number.isNaN(number)) {
				throw Error(`${number} is not valid number between ${min}-${max}`);
			}
		},
		validateTYPE(product) {
			if (!(product instanceof Product)) {
				throw Error(`${product} is invalid product`);
			}
		},
		validateSellQuantity(storeProductQuantity, sellRequestQuantity) {
			if (storeProductQuantity < sellRequestQuantity) {
				throw Error(`The store has not the ${sellRequestQuantity} amount of the product`);
			}
		}
	};

	const util = {
		* genId() {
			let id = 0;
			while (true) {
				yield id++;
			}
		},
		catalogging(product, quantity) {
			return {
				product: product,
				id: product.id,
				quantity: quantity,
				price: product.price
			};
		},
		searchShallowExposition(productCataloged ){
			return {
				product:productCataloged.product,
				quantity:productCataloged.quantity			
			};
		}
	};
	const generatorID = util.genId();
	class Product {
		constructor(manufacturer, model, price) {
			this._id = generatorID.next().value;
			this.manufacturer = manufacturer;
			this.model = model;
			this.price = price;
		}

		get id() {
			return this._id;
		}

		get manufacturer() {
			return this._manufacturer;
		}
		set manufacturer(manufacturer) {
			VALIDATOR.validateSTRING(manufacturer, 1, 20);
			this._manufacturer = manufacturer;
		}

		get model() {
			return this._model;
		}
		set model(model) {
			VALIDATOR.validateSTRING(model, 1, 20);
			this._model = model;
		}

		get price() {
			return this._price;
		}
		set price(price) {
			VALIDATOR.validatePositiveNonZeroNUMBER(price);
			this._price = price;
		}

		getLabel() {
			return `${this.constructor.name} - ${this.manufacturer} ${this.model} -     **${this.price}**`;
		}
    }

	class SmartPhone extends Product {
		constructor(manufacturer, model, price, ...options) {
			super(manufacturer, model, price);
			this.screenSize = options[0];
			this.operatingSystem = options[1];

		}

		get screenSize() {
			return this._screenSize;
		}
		set screenSize(screenSize) {
			VALIDATOR.validatePositiveNonZeroNUMBER(screenSize);
			this._screenSize = screenSize;
		}

		get operatingSystem() {
			return this._operatingSystem;
		}
		set operatingSystem(operatingSystem) {
			VALIDATOR.validateSTRING(operatingSystem, 1, 10);

			this._operatingSystem = operatingSystem;
		}
    }

	class Charger extends Product {
		constructor(manufacturer, model, price, ...options) {
			super(manufacturer, model, price);
			this.outputVoltage = options[0];
			this.outputCurrent = options[1];
		}

		get outputVoltage() {
			return this._outputVoltage;
		}
		set outputVoltage(outputVoltage) {
			VALIDATOR.validateNUMBERinRANGE(outputVoltage, 5, 20);

			this._outputVoltage = outputVoltage;
		}

		get outputCurrent() {
			return this._outputCurrent;
		}
		set outputCurrent(outputCurrent) {
			VALIDATOR.validateNUMBERinRANGE(outputCurrent, 100, 3000);

			this._outputCurrent = outputCurrent;
		}
    }

	class Router extends Product {
		constructor(manufacturer, model, price, ...options) {
			super(manufacturer, model, price);
			this.wifiRange = options[0];
			this.lanPorts = options[1];
		}

		get wifiRange() {
			return this._wifiRange;
		}
		set wifiRange(wifiRange) {
			VALIDATOR.validatePositiveNonZeroNUMBER(wifiRange);

			this._wifiRange = wifiRange;
		}

		get lanPorts() {
			return this._lanPorts;
		}
		set lanPorts(lanPorts) {
			VALIDATOR.validatePositiveNonZeroINTEGER(lanPorts);

			this._lanPorts = lanPorts;
		}
    }

	class Headphones extends Product {
		constructor(manufacturer, model, price, ...options) {
			super(manufacturer, model, price);
			this.quality = options[0];
			this.hasMicrophone = options[1];
		}

		get quality() {
			return this._quality;
		}
		set quality(quality) {
			VALIDATOR.validateQUALITY(quality);

			this._quality = quality;
		}

		get hasMicrophone() {
			return this._hasMicrophone;
		}
		set hasMicrophone(hasMicrophone) {
			this._hasMicrophone = !!hasMicrophone;
		}
    }

	class HardwareStore {
		constructor(name) {
			this.name = name;
			this.products = []; //arr of *unique*ID* products 

			this._sold = 0;
		}

		get name() {
			return this._name;
		}
		set name(name) {
			VALIDATOR.validateSTRING(name, 1, 20);
			this._name = name;
		}

		stock(product, quantity) {
			VALIDATOR.validateTYPE(product);
			VALIDATOR.validatePositiveNonZeroINTEGER(quantity);

			let foundIndex = this.products.findIndex(p => p.id === product.id);
			if (foundIndex >= 0) {
				this.products[foundIndex].quantity += quantity;
			} else {
				this.products.push(util.catalogging(product, quantity));
			}
			return this;
		}
		sell(productId, quantity) {
			VALIDATOR.validatePositiveNonZeroINTEGER(productId);
			VALIDATOR.validatePositiveNonZeroINTEGER(quantity);

			let foundIndex = this.products.findIndex(p => p.id === productId);
			if (foundIndex >= 0) {
				let productQuantityInStore = this.products[foundIndex].quantity;
				VALIDATOR.validateSellQuantity(productQuantityInStore, quantity);

				this.products[foundIndex].quantity -= quantity;

				if (productQuantityInStore === quantity) {
                    //splice if 0
					this.products.splice(foundIndex,1);
				}

                //$sold
				this._sold += quantity * this.products[foundIndex].price;

                //[possible]some data cashing
			}
			return this;
		}
		search(options) {
           
			if (typeof options == 'string') {
				let pattern = new RegExp(options,'i');
				let allFound = this.products.filter(p => {					
					return !!(p.product.model.match(pattern) || p.product.manufacturer.match(pattern));
				});
//should use deep copy => hackable
				let searchResultFormat = allFound.map(x=>util.searchShallowExposition(x));
				return searchResultFormat;
			}
            //options
			else if (typeof options == 'object') {
				let allFound = this.products.filter(p => {
					return !!((!options.hasOwnProperty('manufacturerPattern')||p.product.manufacturer.match(options.manufacturerPattern))
					&&(!options.hasOwnProperty('modelPattern')||p.product.model.match(options.modelPattern))
					&&(!options.hasOwnProperty('type')||p.product.constructor.name.match(options.type))
					&&(!options.hasOwnProperty('minPrice')||p.price >= options.minPrice)
					&&(!options.hasOwnProperty('maxPrice')||p.price <= options.maxPrice));
				});
				//[...allFound]; // destruction needed of [...allFound.product]

//should use deep copy => hackable				
				let searchResultFormat = allFound.map(x=>util.searchShallowExposition(x));
				return searchResultFormat;
			}

		}

		getSold() {
			return this._sold;
		}
    }

	return {
		getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
			return new SmartPhone(manufacturer, model, price, screenSize, operatingSystem);
		},
		getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
			return new Charger(manufacturer, model, price, outputVoltage, outputCurrent);
		},
		getRouter(manufacturer, model, price, wifiRange, lanPorts) {
			return new Router(manufacturer, model, price, wifiRange, lanPorts);
		},
		getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
			return new Headphones(manufacturer, model, price, quality, hasMicrophone);
		},
		getHardwareStore(name) {
			return new HardwareStore(name);
		}
	};
}
const result = solve();



const phone = result.getSmartPhone('HTC', 'One', 10, 5, 'Android');
const charger = result.getCharger('someCharger', 'chargerMan', 20, 15, 1500);
const router = result.getRouter('someRouter', 'routerMan', 30, 100, 3);
const headphones = result.getHeadphones('Sennheiser', 'PXC 550 Wireless', 40, 'high', false);


const store = result.getHardwareStore('Magazin');

store.stock(phone, 5)
	.stock(charger, 5)
	.stock(router, 5)
    .stock(headphones, 5);

console.log(store);


// store.sell(1, 2)
// 	.sell(2, 2)
// 	.sell(3, 2)
// 	.sell(4, 2);
	
	
store.sell(headphones.id,1)
	.sell(charger.id,1);

console.log(store.getSold());
console.log(store);

console.log('________SEARCH___________');
// console.log(store.search('Senn'));

console.log(store.search('senn'));

console.log(store.search({type: 'SmartPhone', maxPrice: 1000}));


console.log(store.search({type: 'Charger', maxPrice: 900}));


// store.sell(headphones.id, 2);
// console.log(store.getSold()); // 680

// Submit the code above this line in bgcoder.com
module.exports = solve; // DO NOT SUBMIT THIS LINE