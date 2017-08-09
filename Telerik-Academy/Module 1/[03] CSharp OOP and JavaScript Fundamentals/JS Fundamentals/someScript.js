function solve() {
    // const validation = {
    //     ValidateString(str) {
    //         if (typeof(str) != "string") {
    //             throw Error("Invalid string");
    //         }
    //         return str;
    //     }
    // };

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

    class CellPhone extends Product() {
        constructor(manufacturer, type, price, charger) {
            super(manufacturer, type, price);
            this._charger = charger;
        }
        get charger() { return this._charger; }
    }

    return {
        cellPhone(charger, manufacturer, type, price) {
            return new CellPhone(charger, manufacturer, type, price);
        }
        // cellphone: new CellPhone(charger, manufacturer, type, price)
    }
}

// let solution = solve();
// let cellphone1 = solution.cellphone("some Charger", "Manufacturer", "type", "100$");
// console.log(cellphone1);