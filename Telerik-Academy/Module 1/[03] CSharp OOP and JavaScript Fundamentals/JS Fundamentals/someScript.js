function solve() {
    const validation = {
        ValidateString(str) {
            if (typeof(str) != "string") {
                throw Error("Invalid string");
            }
            return str;
        }
    };

    class Product {
        constructor(manufacturer, type, price) {
            this._manufacturer = manufacturer;
            this._type = type;
            this._price = price;
        }
    }

    class CellPhone extends Product() {
        constructor(charger, ...params) {
            super(...params);
            this._charger = ValidateString(charger);
        }
        set(charger) { this._charger = charger; }
        get() { return this._charger; }
    }

    return {
        cellphone: new CellPhone(charger, manufacturer, type, price)
    }
}

let solution = solve();
let cellphone1 = solution.cellphone("some Charger", "Manufacturer", "type", "100$");
console.log(cellphone1);