/* globals module */

"use strict";

function solve() {

    //create external Generic validation file to be used by exam-specific validation concrete implementation
    class Product {
        constructor(productType, name, price) {
            this._productType = productType;
            this._name = name;
            this._price = price;
        }

        get productType() { return this._productType; }
        get name() { return this._name; }
        get price() { return this._price; }
    }

    class ShoppingCart {
        constructor() {
            this._products = [];
        }
        get products() { return this._products; }

        add(product) {
            // validate

            //Adds the `product` to the `products` array in this `ShoppingCart` instance
            return this;
        }

        remove(product) {
            // validate The `ShoppingCart` instance does not contain this product 
            // validate There are not products in the `ShoppingCart` instance

            //remove products that has the same `name`, `price` and `productType`            
        }

        showCost() {
            // total sum of all products
            // return 0 if none
        }

        showProductTypes() {
            //  Returns the **unique productTypes** of the products added to this 
            // sorted alphabet.
            //..
        }

        getInfo() {}
    }
    return {
        Product,
        ShoppingCart
    };
}

module.exports = solve;