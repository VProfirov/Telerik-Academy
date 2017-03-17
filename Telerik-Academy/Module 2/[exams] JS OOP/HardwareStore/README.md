# Hardware Store

Implement functionality for hardware stores.

_Notes:_
- There is no need to specify an error message when **throwing** an `Error`.
- Use single quotes for strings: `'string'`

## Class descriptions

### `class Product`
- Properties
  - `id` - should be generated automatically and be different for different products
  - `manufacturer` - string with length between 1 and 20 symbols (inclusive)
  - `model` - string with length between 1 and 20 symbols (inclusive)
  - `price` - positive, non-zero number
  - **Throw** if any of the properties are invalid
- Methods:
  - `getLabel()` - returns a string: what should be written on the label
    - read on :)

### `class SmartPhone` extends `Product`
- Properties:
  - `screenSize` - positive, non-zero number
  - `operatingSystem` - string with length between 1 and 10 symbols (inclusive)
  - **Throw** if any of the properties are invalid
- Methods:
  - `getLabel()` - returns a string: what should be written on the label
    - `SmartPhone - MANUFACTURER MODEL - **PRICE**`

### `class Charger` extends `Product`
- Properties:
  - `outputVoltage` - number between 5 and 20 (inclusive)
  - `outputCurrent` - number between 100 and 3000 (inclusive)
    - its in milliamperes if you are asking
  - **Throw** if any of the properties are invalid
- Methods:
  - `getLabel()` - returns a string: what should be written on the label
    - `Charger - MANUFACTURER MODEL - **PRICE**`

### `class Router` extends `Product`
- Properties:
  - `wifiRange` - positive, non-zero number
  - `lanPorts` - positive, non-zero **integer** number
  - **Throw** if any of the properties are invalid
- Methods:
  - `getLabel()` - returns a string: what should be written on the label
    - `Router - MANUFACTURER MODEL - **PRICE**`

### `class Headphones` extends `Product`
- Properties:
  - `quality` - string, should be either `high`, `mid` or `low`
    - **Throw** if `quality` is invalid
  - `hasMicrophone` - boolean
    - convert true-like javascript values to `true` and false-like to `false`
- Methods:
  - `getLabel()` - returns a string: what should be written on the label
    - `Headphones - MANUFACTURER MODEL - **PRICE**`

### `class HardwareStore`
- Properties:
  - `name` - string with length between 1 and 20 symbols (inclusive)
    - **Throw** if invalid
  - `products` - array of unique products currently in storage
    - should be empty when the store is created
- Methods:
  - `stock(product, quantity)` - adds new products
    - `product` should be a valid `Product` instance
	- `quantity` should be a positive, non-zero integer number
	- **Throw otherwise**
	- **Should provide chaining**
  - `sell(productId, quantity)` - sells products
	- `quantity` should be a positive, non-zero integer number
	- there should be at least `quantity` products with id `productId` available in the store
	- **Throw otherwise**
	- **Should provide chaining**
  - `getSold()` - returns the amount of money earned from selling in the current store
  - `search(pattern)` - returns an array of unique products containing `pattern` in their model or manufacturer name
    - perform **case insensitive** search
    - each element in the array should have 2 keys:
	  - `product` - the product instance
	  - `quantity` - the available quantity of that product
  - `search(options)` - advanced search, same as above
    - options is an object with **optional** keys:
	  - `manufacturerPattern` - string, should be contained in manufacterures **(case sensitive)**
	  - `modelPattern` - string, should be contained in models **(case sensitive)**
	  - `type` - string - `SmartPhone`, `Charger`, `Router` or `Headphones` - the product should be of the specified type
	  - `minPrice` - number - the product should not be cheaper than `minPrice`
	  - `maxPrice` - number - the product should not be more expensive than `maxPrice`

## Sample usage

```javascript
const result = solve();

const phone = result.getSmartPhone('HTC', 'One', 903, 5, 'Android');

console.log(phone.getLabel()); // SmartPhone - HTC One - **903**

const headphones = result.getHeadphones('Sennheiser', 'PXC 550 Wireless', 340, 'high', false);
const store = result.getHardwareStore('Magazin');

store.stock(phone, 1)
	.stock(headphones, 15);

console.log(store.search('senn'));
/*
[ { product:
     Headphones { ... },
    quantity: 15 } ]
*/

console.log(store.search({type: 'SmartPhone', maxPrice: 1000});
/*
[ { product:
     SmartPhone { ... },
    quantity: 1 } ]
*/

console.log(store.search({type: 'SmartPhone', maxPrice: 900});
/* [] */

store.sell(headphones.id, 2);
console.log(store.getSold()); // 680
```

## Solution template

```javascript
function solve() {
	// Your classes

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

// Submit the code above this line in bgcoder.com
module.exports = solve; // DO NOT SUBMIT THIS LINE
```
Linux, Windows	macOS	Feature	Supported
ctrl+space	ctrl+space	Basic code completion (the name of any class, method or variable)	✅
ctrl+shft+space	ctrl+shft+space	Smart code completion (filters the list of methods and variables by expected type)	N/A
ctrl+shift+enter	cmd+shift+enter	Complete statement	✅
ctrl+p	cmd+p	Parameter info (within method call arguments)	✅
ctrl+q	ctrl+j	Quick documentation lookup	✅
ctrl+f1	shift+f1	External Doc	N/A
ctrl+mouseover	cmd+mouseover	Brief Info	N/A
ctrl+f1	cmd+f1	Show descriptions of error or warning at caret	✅
alt+insert	cmd+n	Generate code... (Getters, Setters, Constructors, hashCode/equals, toString)	✅
ctrl+o	ctrl+o	Override methods	N/A
ctrl+i	ctrl+i	Implement methods	N/A
ctrl+alt+t	cmd+alt+t	Surround with... (if..else, try..catch, for, synchronized, etc.)	N/A
ctrl+/	cmd+/	Comment/uncomment with line comment	✅
ctrl+numpad_divide	cmd+numpad_divide	Comment/uncomment with line comment	✅
ctrl+alt+/	cmd+alt+/	Comment/uncomment with block comment	✅
ctrl+alt+numpad_divide	cmd+alt+numpad_divide	Comment/uncomment with block comment	✅
ctrl+w	alt+up	Select successively increasing code blocks	✅
ctrl+shift+w	alt+down	Decrease current selection to previous state	✅
alt+q	ctrl+shift+q	Context info	N/A
alt+enter	alt+enter	Show intention actions and quick-fixes	✅
ctrl+alt+l	cmd+alt+l	Reformat code	✅
ctrl+alt+l	cmd+alt+l	Reformat selected code	✅
ctrl+alt+o	ctrl+alt+o	Optimize imports	N/A
ctrl+alt+i	ctrl+alt+i	Auto-indent line(s)	N/A
tab	tab	Indent selected lines	N/A
shift+tab	shift+tab	Unindent selected lines	N/A
ctrl+x	cmd+x	Cut current line or selected block to clipboard	✅
shift+delete	cmd+delete	Cut current line or selected block to clipboard	✅
ctrl+c	cmd+c	Copy current line or selected block to clipboard	✅
ctrl+v	cmd+v	Paste from clipboard	✅
ctrl+shift+v	cmd+shift+v	Paste from recent buffers...	N/A
ctrl+d	cmd+d	Duplicate current line or selected block	✅
ctrl+y	cmd+backspace	Delete line at caret	✅
ctrl+shift+j	ctrl+shift+j	Smart line join	✅
ctrl+enter	cmd+enter	Smart line split	✅
shift+enter	shift+enter	Start new line	✅
ctrl+shift+u	cmd+shift+u	Toggle case for word at caret or selected block	N/A
ctrl+shift+]	cmd+shift+]	Select till code block end	N/A
ctrl+shift+[	cmd+shift+[	Select till code block start	N/A
ctrl+delete	alt+delete	Delete to word end	✅
ctrl+backspace	alt+backspace	Delete to word start	✅
ctrl+=	cmd+=	Expand code block	✅
ctrl+numpad_add	cmd+numpad_add	Expand code block	✅
ctrl+-	cmd+-	Collapse code block	✅
ctrl+numpad_subtract	cmd+numpad_subtract	Collapse code block	✅
ctrl+shift+=	cmd+shift+=	Expand all	✅
ctrl+shift+numpad_add	cmd+shift+numpad_add	Expand all	✅
ctrl+shift+-	cmd+shift+-	Collapse all	✅
ctrl+shift+numpad_subtract	cmd+shift+numpad_subtract	Collapse all	✅
ctrl+f4	cmd+w	Close active editor tab	✅
alt+j	ctrl+g	Add selection for Next Occurrence	✅
alt+shift+j	ctrl+shift+g	Unselect Occurrence	✅
Search/Replace

Linux, Windows	macOS	Feature	Supported
shfit shift	shfit shift	Search everywhere	N/A
ctrl+f	cmd+f	Find	✅
f3	cmd+g	Find next	✅
shift+f3	cmd+shift+g	Find previous	✅
ctrl+r	cmd+r	Replace	✅
ctrl+shift+f	cmd+shift+f	Find in path	✅
ctrl+shift+r	cmd+shift+r	Replace in path	✅
ctrl+shift+s	cmd+shift+s	Search structurally (Ultimate Edition only)	N/A
ctrl+shift+m	cmd+shift+m	Replace structurally (Ultimate Edition only)	N/A
Usage Search

Linux, Windows	macOS	Feature	Supported
alt+f7	alt+f7	Find usages	✅
ctrl+f7	cmd+f7	Find usages in file	N/A
ctrl+shift+f7	cmd+shift+f7	Highlight usages in file	N/A
ctrl+alt+f7	cmd+alt+f7	Show usages	N/A
Compile and Run

Linux, Windows	macOS	Feature	Supported
ctrl+f9	cmd+f9	Make project (compile modifed and dependent)	✅
ctrl+shift+f9	cmd+shift+f9	Compile selected file, package or module	N/A
alt+shift+f10	ctrl+alt+r	Select configuration and run	✅
alt+shift+f9	ctrl+alt+d	Select configuration and debug	✅
shift+f10	ctrl+r	Run	N/A
shift+f9	ctrl+d	Debug	✅
ctrl+shift+f10	ctrl+shift+r	Run context configuration from editor	N/A
Debugging

Linux, Windows	macOS	Feature	Supported
f8	f8	Step over	✅
f7	f7	Step into	✅
shift+f7	shift+f7	Smart step into	N/A
shift+f8	shift+f8	Step out	✅
alt+f9	alt+f9	Run to cursor	✅
alt+f8	alt+f8	Evaluate expression	✅
alt+f8	alt+f8	Evaluate expression (selection)	✅
f9	cmd+alt+r	Resume program	✅
ctrl+f8	cmd+f8	Toggle breakpoint	✅
ctrl+shift+f8	cmd+shift+f8	View breakpoints	✅
Navigation

Linux, Windows	macOS	Feature	Supported
ctrl+n	cmd+o	Go to class	✅
ctrl+shift+n	cmd+shift+o	Go to file	✅
ctrl+alt+shift+n	cmd+alt+o	Go to symbol	✅
alt+left	ctrl+left	Go to previous editor tab	✅
shift+cmd+[	Go to previous editor tab	✅
alt+right	ctrl+right	Go to next editor tab	✅
shift+cmd+]	Go to next editor tab	✅
f12	f12	Go back to previous tool window	N/A
escape	escape	Go to editor (from tool window)	N/A
shift+escape	shift+escape	Hide active or last active window (Sidebar)	✅
shift+escape	shift+escape	Hide active or last active window (Output)	✅
shift+escape	shift+escape	Hide active or last active window (Problems)	✅
shift+escape	shift+escape	Hide active or last active window (Debug Console)	✅
shift+escape	shift+escape	Hide active or last active window (Terminal)	✅
shift+escape	shift+escape	Hide active or last active window (Panel)	N/A
ctrl+shift+f4	cmd+shift+f4	Close active run/messages/find/... tab	N/A
ctrl+g	cmd+l	Go to line	✅
ctrl+e	cmd+e	Recent files popup	✅
ctrl+alt+left	cmd+alt+left	Navigate back	✅
cmd+[	Navigate back	✅
ctrl+alt+right	cmd+alt+right	Navigate forward	✅
cmd+]	Navigate forward	✅
ctrl+shift+backspace	cmd+shift+backspace	Navigate to last edit location	N/A
alt+f1	alt+f1	Select current file or symbol in any view	N/A
ctrl+b	cmd+b	Go to declaration	✅
ctrl+alt+b	cmd+alt+b	Go to implementation(s)	N/A
ctrl+shift+i	alt+space	Open quick definition lookup	✅
cmd+y	Open quick definition lookup	✅
ctrl+shift+b	ctrl+shift+b	Go to type declaration	✅
ctrl+u	cmd+u	Go to super-method/super-class	N/A
alt+up	ctrl+up	Go to previous method	N/A
alt+down	ctrl+down	Go to next method	N/A
ctrl+]	cmd+]	Move to code block end	N/A
ctrl+[	cmd+[	Move to code block start	N/A
ctrl+f12	cmd+f12	File structure popup	✅
ctrl+h	ctrl+h	Type hierarchy	N/A
ctrl+shift+h	cmd+shift+h	Method hierarchy	N/A
ctrl+alt+h	ctrl+alt+h	Call hierarchy	N/A
f2	f2	Next highlighted error	N/A
shift+f2	shift+f2	Previous highlighted error	N/A
f4	f4	Edit source	✅
ctrl+enter	cmd+down	View source	✅
shift+ctrl+down	shift+cmd+down	Move Statement Down	✅
shift+ctrl+up	shift+cmd+up	Move Statement Up	✅
alt+home	alt+home	Show navigation bar	N/A
f11	f3	Toggle bookmark	N/A
ctrl+f11	alt+f3	Toggle bookmark with mnemonic	N/A
ctrl+0	ctrl+0	Go to numbered bookmark	N/A
shift+f11	cmd+f3	Show bookmarks	N/A
Refactoring

Linux, Windows	macOS	Feature	Supported
f5	f5	Copy	N/A
f6	f6	Move	N/A
alt+delete	cmd+delete	Safe Delete	N/A
shift+f6	shift+f6	Rename	✅
ctrl+f6	cmd+f6	Change Signature	N/A
ctrl+alt+n	cmd+alt+n	Inline	N/A
ctrl+alt+m	cmd+alt+m	Extract Method	N/A
ctrl+alt+v	cmd+alt+v	Extract Variable	N/A
ctrl+alt+f	cmd+alt+f	Extract Field	N/A
ctrl+alt+c	cmd+alt+c	Extract Constant	N/A
ctrl+alt+p	cmd+alt+p	Extract Parameter	N/A
VCS/Local History

Linux, Windows	macOS	Feature	Supported
ctrl+k	cmd+k	Commit project to VCS	✅
ctrl+t	cmd+t	Update project from VCS	✅
alt+shift+c	alt+shift+c	View recent changes	N/A
ctrl+`	ctrl+v	‘VCS’ quick popup	✅
Live Templates

Linux, Windows	macOS	Feature	Supported
ctrl+alt+j	cmd+alt+j	Surround with Live Template	N/A
ctrl+j	cmd+j	Insert Live Template	N/A
General

Linux, Windows	macOS	Feature	Supported
alt+0	cmd+0	Activate Messages window (Problems)	✅
alt+numpad0	cmd+numpad0	Activate Messages window (Problems)	✅
alt+1	cmd+1	Open corresponding tool window (Explorer)	✅
alt+numpad1	cmd+numpad1	Open corresponding tool window (Explorer)	✅
alt+1	cmd+1	Close corresponding tool window (Explorer)	✅
alt+numpad1	cmd+numpad1	Close corresponding tool window (Explorer)	✅
alt+3	cmd+3	Open corresponding tool window (Search)	✅
alt+numpad3	cmd+numpad3	Open corresponding tool window (Search)	✅
alt+3	cmd+3	Close corresponding tool window (Search)	✅
alt+numpad3	cmd+numpad3	Close corresponding tool window (Search)	✅
alt+5	cmd+5	Open corresponding tool window (Debug)	✅
alt+numpad5	cmd+numpad5	Open corresponding tool window (Debug)	✅
alt+5	cmd+5	Close corresponding tool window (Debug)	✅
alt+numpad5	cmd+numpad5	Close corresponding tool window (Debug)	✅
alt+9	cmd+9	Open corresponding tool window (Git)	✅
alt+numpad9	cmd+numpad9	Open corresponding tool window (Git)	✅
alt+9	cmd+9	Close corresponding tool window (Git)	✅
alt+numpad9	cmd+numpad9	Close corresponding tool window (Git)	✅
ctrl+s	cmd+s	Save all	✅
ctrl+alt+y	cmd+alt+y	Synchronize	✅
ctrl+alt+f	ctrl+cmd+f	Toggle full screen mode	✅
ctrl+shift+f12	cmd+shift+f12	Toggle maximizing editor	✅
alt+shift+f	alt+shift+f	Add to Favorites	N/A
alt+shift+i	alt+shift+i	Inspect current file with current profile	N/A
ctrl+`	ctrl+`	Quick switch current scheme	✅
ctrl+alt+s	cmd+,	Open Settings dialog	✅
ctrl+alt+s	cmd+numpad_separator	Open Settings dialog	✅
ctrl+alt+shift+s	cmd+;	Open Project Structure dialog	✅
ctrl+shift+a	shift+cmd+a	Find Action	✅
ctrl+tab	ctrl+tab	Switch between tabs and tool window	✅
Custom

Linux, Windows	macOS	Feature	Supported
f7	f7	Next difference	✅
shift+f7	shift+f7	Previous difference	✅
alt+ctrl+enter	alt+cmd+enter	Start new line before current	✅
shift+ctrl+enter	shift+cmd+enter	Start new line	✅
alt+f12	alt+f12	Open corresponding tool window (Terminal)	✅
ctrl+shift+alt+j	ctrl+cmd+g	Sublime Text style multiple selections	✅
alt+left	shift+cmd+[	Select previous tab (Terminal)	✅
alt+right	shift+cmd+]	Select next tab (Terminal)	✅