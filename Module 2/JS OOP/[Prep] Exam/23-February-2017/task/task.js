function solve() {
	// VALIDATION
	const util = {
		validatePrimitives: {
			basicSTRING(str) {
				if (typeof str != 'string') {
					throw Error('Not a STRING');
				}
			},
			STRINGinRANGE(str, minLen, maxLen) {
				if (typeof str != 'string' || str.length < minLen || str.length > maxLen) {
					throw Error(`${str} is not valid string between ${minLen}-${maxLen}`);
				}
			},
			positiveNonZeroNUMBER(number) {
				if (typeof number != 'number' || number < 0 || Number.isNaN(number)) {
					throw Error(`${number} is not positive non zero number`);
				}
			},
			NUMBERinRANGE(number, min, max) {
				if (typeof number != 'number' || number < min || number > max || Number.isNaN(number)) {
					throw Error(`${number} is not valid number between ${min}-${max}`);
				}
			},
			basicARRAY(arr) {
				if (!Array.isArray(arr)) {
					throw Error(`${arr} is not an array`);
				}
			},
		},
		standard: {
			validateName(name) {
				util.validatePrimitives.basicSTRING(name);
				if (!name.match(/^([a-zA-Z0-9]|\s){1,24}$/)) {
					throw Error(`${name} doesn't match the specific: a-Z0-9|\s`);
				}
			},
			validateDescription(description) {
				util.validatePrimitives.basicSTRING(description);
			},
			validateVersion(version) {
				util.validatePrimitives.positiveNonZeroNUMBER(version);
			},
			validateRating(rating) {
				util.validatePrimitives.NUMBERinRANGE(rating, 1, 10);
			},
			validateHostname(hostname) {
				util.validatePrimitives.STRINGinRANGE(hostname, 1, 32);
			},
			validateDeviceApps(apps){
				if(Array.isArray(apps)){
					apps.every(app => util.validateAppINSTANCE(app));					
				}
				else{
					throw Error('apps must be an array of apps');
				}
			}
		},
		extras: {
			changeIfFound(foundIndex, newApp) {
				// this method is just for comparing purpuses => use the splice-push
				if (foundIndex >= 0) {
					this._apps[foundIndex].version = newApp.version;
					this._apps[foundIndex].description = newApp.description;
					this._apps[foundIndex].rating = newApp.rating;
				} else {
					this._apps.push(util.appBuild(newApp));
				}
			}
		},
		validateNewVERSION(newversion, version) {
			util.validatePrimitives.positiveNonZeroNUMBER(newversion);
			if (newversion <= version) {
				throw Error(`${newversion} is INVALID VERSION! 
				The new version should be > ${version}`);
			}
		},
		validateAppINSTANCE(app) {
			if (!(app instanceof App)) {
				throw Error('Invalid instance of App');
			}
		},

		appBuild(app) {
			return {
				description: app.description,
				name: app.name,
				version: app.version,
				rating: app.rating,
				apps: app.apps
			};
		}
	};
	class App {
		constructor(name, description, version, rating) {
			util.standard.validateName(name);
			util.standard.validateDescription(description);
			util.standard.validateVersion(version);
			util.standard.validateRating(rating);

			this._name = name;
			this._description = description;
			this._version = version;
			this._rating = rating;
		}
		get name() {
			return this._name;
		}
		get description() {
			return this._description;
		}
		get version() {
			return this._version;
		}
		get rating() {
			return this._rating;
		}


		release(options) {
			if (typeof options != 'object') {
				util.validateNewVERSION(options, this._version);
				this._version = options;
			} else {
				util.validateNewVERSION(options.version, this._version);
				this._version = options.version;

				if (options.hasOwnProperty('description')) {
					util.standard.validateDescription(options.description);
					this._description = options.description;
				}

				if (options.hasOwnProperty('rating')) {
					util.standard.validateRating(options.rating);
					this._rating = options.rating;
				}
			}
			return this;
		}
	}
	class Store extends App {
		constructor(...props) {
			super(...props);
			this._apps = [];
		}
		get apps() {
			return this._apps;
		}

		uploadApp(app) {
			util.validateAppINSTANCE(app);
		
			let foundIndex = this._apps.findIndex(p => p.name == app.name);
			if (foundIndex >= 0) {
				this._apps.splice(foundIndex, 1);
			}

			this._apps.push(util.appBuild(app));

			return this;
		}
		takedownApp(name) {
			util.standard.validateName(name);

			let foundIndex = this._apps.findIndex(app => app.name == name);
			if (foundIndex < 0) {
				throw Error('App with such name is not found');
			} else {
				this._apps.splice(foundIndex, 1);
			}
			return this;
		}
		//FIXME: has some problems to validate
		search(pattern) {
			util.validatePrimitives.basicSTRING(pattern);

			let regex = new RegExp(pattern, 'i');
			let foundApps = this._apps.filter(app => !!app.name.match(regex)); //refactor ?
			return foundApps.sort((app1,app2) => app1.name.localeCompare(app2.name));
			// return foundApps.sort();
		}
		listMostRecentApps(count) {
			count = count || 10; // mocha is bugged for (count=10)

			return [...this._apps].reverse().slice(0, count);			
		}
		listMostPopularApps(count) {
			count = count || 10; // ES6 method length??

			return this._apps.map((app, index) => ({app,index}))
				// arr of objs set as: [{app,index},]
				.sort((app1, app2) => {
					//  i2 - i1 => reverse
					if (app2.app.rating !== app1.app.rating) {
						return app2.app.rating - app1.app.rating;
					}
					return app2.index - app1.index;
				})
				.slice(0, count)
				.map(obj => obj.app);
		}
	}
	class Device {
		constructor(hostname, apps) {
			util.standard.validateHostname(hostname);
			util.standard.validateDeviceApps(apps);
			this._hostname = hostname;
			this._apps = apps;
		}
		get hostname() {
			return this._hostname;
		}
		get apps() {
			return this._apps;
		}

		search(pattern) {
			let regex = new RegExp(pattern, 'i');
			let foundApps = this._apps.filter(app => !!app.name.match(regex));
			return foundApps.sort();
		}
		install(name) {
			return this;
		}
		uninstall(name) {
			return this;
		}
		listInstalled() {

		}
		update() {
			return this;
		}
	}

	return {
		createApp(name, description, version, rating) {
			return new App(name, description, version, rating);
		},
		createStore(name, description, version, rating) {
			return new Store(name, description, version, rating);
		},
		createDevice(hostname, apps) {
			return new Device(hostname, apps);
		}
	};
}

// Submit the code above this line in bgcoder.com
module.exports = solve;

let result = solve();
let app = result.createApp('app', 'description of an app', 1, 4);
console.log(app);

let store = result.createStore('sotre', 'description', 0.2, 4);
console.log(store);
console.log(store.release);//done
console.log(store.uploadApp);
console.log(store.takedownApp);
console.log(store.search);
console.log(store.listMostPopularApps);
console.log(store.listMostRecentApps);
console.log('---------');
// console.log(store.uploadApp(app));
store.uploadApp(app);
