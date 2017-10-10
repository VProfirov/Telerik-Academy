function solve(args) {
    let pointer = 0;
    let pricesCount = Number(args[pointer]);
    let pricesMap = new Map();

    while (pointer++ < pricesCount) {
        let item = args[pointer].split(" ");
        let itemPrice = item.pop();
        item = item.join(" ");
        pricesMap.set(item, itemPrice);
    }

    let orderedItemsCount = Number(args[pointer]);
    let orderListEnd = orderedItemsCount + pointer;
    let orderMap = new Map();
    while (pointer++ < orderListEnd) {
        let items = args[pointer].split(", ");
        let itemCount = 0;
        let itemName = "";
        // console.log(items);
        for (var itemIndex = 0; itemIndex < items.length; itemIndex++) {
            let itemWord = items[itemIndex].split(" ");

            // console.log(typeof(itemWord[0])); // itemWord <object> [string,...]
            // console.log(Number(itemWord[0])); // Number | NaN
            if (!isNaN(Number(itemWord[0]))) {
                itemCount = Number(itemWord.shift());
                itemName = itemWord.join(" ");
            } else {
                itemCount = 1;
                itemName = itemWord.join(" ");
            }
            // console.log(itemName + " itemWord || " + itemCount + " itemCount");
            //NB! indirect Map conversion to array like Object
            // if (orderMap[itemName] !== undefined) {
            //     orderMap[itemName] += itemCount;
            // } else {
            //     orderMap[itemName] = itemCount;
            // }
            if (orderMap.get(itemName) !== undefined) {
                orderMap.set(itemName, orderMap.get(itemName) + itemCount);
            } else {
                orderMap.set(itemName, itemCount);
            }
        }
        // console.log("ITEMS----");
        // console.log(items);
        // console.log("-----");
    }
    //NB! practicing DataStructures in JS <=> for this solution is proper to use Objects
    // console.log(orderMap);
    // console.log(pricesMap);
}

const input = [
    "5",
    "milk 1.2",
    "orange juice 2.9",
    "icecream 2",
    "cake 5.1",
    "beer 1.2",
    "5", /**NB! :D each line is a list => sum the items in A list (stdout) */
    /** 2 main problems from kid: 
     * tasks seems boring => task not read completely and with understanding, a.k. high chance something is missed
     ** something missed <=> something is complex looking
     * thought from the COMPLEX towards SIMPLE*/
    "2 beer, 3 orange juice",
    "milk, cake",
    "icecream, 2 cake",
    "icecream, icecream, 3 icecream",
    "5 orange juice, 3 orange juice, orange juice, orange juice"
];
solve(input);