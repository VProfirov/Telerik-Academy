function solve() {
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
        searchShallowExposition(productCataloged) {
            return {
                product: productCataloged.product,
                quantity: productCataloged.quantity
            };
        }
    };
    const generatorID = util.genId();

    class Product {
        constructor(manufacturer, model, price) {
            VALIDATOR.validateSTRING(manufacturer, 1, 20);
            VALIDATOR.validateSTRING(model, 1, 20);
            VALIDATOR.validatePositiveNonZeroNUMBER(price);

            this._id = generatorID.next().value;
            this._manufacturer = manufacturer;
            this._price = price;
            this._model = model;
        }
        get manufacturer() { return this._manufacturer; }
        set manufacturer(manufacturer) {
            VALIDATOR.validateSTRING(manufacturer, 1, 20);
            this._manufacturer = manufacturer;
        }

        get model() { return this._model; }
        set model(model) {
            VALIDATOR.validateSTRING(model, 1, 20);
            this._model = model;
        }

        get price() { return this._price; }
        set price(price) {
            VALIDATOR.validatePositiveNonZeroNUMBER(price);
            this._price = price;
        }

        getLabel() {
            return `${constructor.name} - ${this.model} - **${this.price}**`;
        }
    }

    class SmartPhone extends Product {
        constructor() {
            super();
        }
    }

    return {
        getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
            // returns SmarhPhone instance
        },
        getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
            // returns Charger instance
        },
        getRouter(manufacturer, model, price, wifiRange, lanPorts) {
            // returns Router instance
        },
        getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
            // returns Headphones instance
        },
        getHardwareStore(name) {
            // returns HardwareStore instance
        }
    };
}

const result = solve();
const hwStore = result.getHardwareStore("MrRobot");
const phone = result.getSmartPhone("HTC", "One M7", "$150", "5", "Android");
console.log(hwStore);
console.log(phone);