function solve() {
	// VALIDATION
	const util = {
		validateSSTRING(str){
			if (str != 'string') {
				throw Error('Not a STRING');
			}
		},
		validateSTRINGinRANGE(str, minLen, maxLen) {
			if (typeof str != 'string' || str.length < minLen || str.length > maxLen) {
				throw Error(`${str} is not valid string between ${minLen}-${maxLen}`);
			}
		},
		validatePositiveNonZeroNUMBER(number) {
			if (typeof number != 'number' || number < 0 || Number.isNaN(number)) {
				throw Error(`${number} is not positive non zero number`);
			}			
		},
		validateNUMBERinRANGE(number, min, max) {
			if (typeof number != 'number' || number < min || number > max || Number.isNaN(number)) {
				throw Error(`${number} is not valid number between ${min}-${max}`);
			}
		},
		validateVERSION(newversion,version){
			util.validatePositiveNonZeroNUMBER(newversion);
			if(newversion<=version){
				throw Error('Invalid version! The new version should be >');
			}
		}
	};
	class App{
		constructor(name,description,version,rating){
			this._name = name;
			this._description = description;
			this._version = version;
			this._rating = rating;			
		}
		get name(){return this._name;}
		set	name(name){
			util.validateSTRINGinRANGE(name,1,24);
			this._name = name;
		}

		get	description(){return this._description;}
		set	description(description){
			util.validateSSTRING(description);
			this._description = description;
		}

		get	version(){return this._version;}
		set	version(version){
			util.validatePositiveNonZeroNUMBER(version);
			this._version = version;
		}			
						
		get	rating(){return this._rating;}
		set	rating(rating){
			util.validateNUMBERinRANGE(rating,1,10);
			this._rating = rating;
		}
			
		release(options){
			//FIXME: options - version part .... the fallowing is not the full one
			util.validateVERSION(options,this._version);//?
			this._version = options;

			//FIXME: start from here --> is incorrect
			if(typeof options != 'object'){
				util.validateOPTIONS();
			}
			else{
				
			}
		}
	}
	class Store extends App{
		constructor(...props){
			super(props);
		}
	}
	class Device{
		constructor(hostname){
			this._hostname = hostname;
			this._apps = [];
		}
	}

	return {
		createApp(name, description, version, rating) {
			// returns a new App object
		},
		createStore(name, description, version, rating) {
			// returns a new Store object
		},
		createDevice(hostname, apps) {
			// returns a new Device object
		}
	};
}

// Submit the code above this line in bgcoder.com
module.exports = solve;