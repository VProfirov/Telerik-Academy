function solve() {

    class Product {
        constructor(manufacturer, type, price) {
            this._manufacturer = manufacturer;
            this._type = type;
            this._price = price;
        }

        get manufacturer() { return this._manufacturer; }
        get type() { return this._price; }
        get price() { return this._price; }
    }

    class Phone extends Product {
        constructor(manufacturer, type, price, charger) {
            super(manufacturer, type, price);
            this._charger = charger;
        }
        get charger() { return this._charger; }
    }

    return {
        cellPhone(charger, manufacturer, type, price) {
            return new Phone(charger, manufacturer, type, price);
        },
        someProduct(manufacturer, type, price) {
            return new Product(manufacturer, type, price)
        }

    };
}

let result = solve();
let cell = result.cellPhone("some Charger", "Manufacturer", "type", "100$");
let pr = result.someProduct("Manufacturer", "type", "100$");
console.log(cell);
console.log(pr);
console.log(cell.charger);