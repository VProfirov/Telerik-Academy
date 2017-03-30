function solve() {
	// VALIDATION
	const util = {
		validateSTRING(str){
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
		},
		validateAppINSTANCE(app){
			if(!(app instanceof App)){
				throw Error('Invalid instance of App');
			}
		},

		appBuild(app){
			return {
				description: app.description,
				name:app.name,
				version: app.version,
				rating: app.rating,
				apps: app.apps
			};
		}
	};
	class App{
		constructor(name,description,version,rating){
			util.validateSTRINGinRANGE(name,1,24);
			util.validateSTRING(description);
			util.validatePositiveNonZeroNUMBER(version);
			util.validateNUMBERinRANGE(rating,1,10);
			
			
			this._name = name;
			this._description = description;
			this._version = version;
			this._rating = rating;			
		}
		get name(){return this._name;}
		get	description(){return this._description;}
		get	version(){return this._version;}
		get	rating(){return this._rating;}
		
			
		release(options){
			if(typeof options != 'object'){
				util.validateVERSION(options,this._version);
				this._version = options;
			}
			else{
				util.validateVERSION(options.version,this._version);
				this._version = options.version;

				if(options.hasOwnProperty('description')){
					util.validateSTRING(options.description);					
					this._description = options._description;
				}

				if(options.hasOwnProperty('rating')){
					util.validateNUMBERinRANGE(options.rating,1,10);					
					this._rating = options._rating;
				}
			}
			return this;			
		}
	}
	class Store extends App{
		constructor(...props){
			super(props);
			this._apps = [];
		}
		get apps(){return this._apps;}

		uploadApp(app){
			util.validateAppINSTANCE(app);

			let foundIndex = this._apps.findIndex(p=> p.name == app.name);
			util.validateVERSION(app.version,this._apps[foundIndex].version);
			if(foundIndex>=0){
				util.validateVERSION(app.version,this._apps[foundIndex.version]);
				this._apps[foundIndex].version = app.version;
				this._apps[foundIndex].description = app.description;
				this._apps[foundIndex].rating = app.rating;				
			}
			else{
				this._apps.push(util.appBuild(app));
			}

			return this;
		}
		takedownApp(name){
			util.validateSTRING(name);
			let foundIndex = this._apps.findIndex(app => app.name == name);
			if(foundIndex<0){
				throw Error('App with ushc name is not found');
			}else{
				this._apps.splice(foundIndex);
			}
			return this;
		}
		search(pattern){
			let regex = new RegExp(pattern,'i');
			let foundApps = this._apps.filter(app => !!app.name.match(regex)); //refactor ?
			return foundApps.sort();
		}
		listMostRecentApps(count = 10){
			return [...this._apps].reverse().slice(0,count);
		}
		listMostPopularApps(count = 10){
			return this._apps.map((app,index) =>({app,index}))
							// arr of objs set as: [{app,index},]
							.sort((app1,app2) =>{
								//  i2 - i1 => reverse
								if(app2.rating != app1.rating){
									return app2.rating - app1.rating;
								}
								return app2.index - app1.index;
							})
							.slice(0,count)
							.map(obj => obj.app);
		}
	}
	class Device{
		constructor(hostname,preinstalledApps){
			util.validateSTRING(hostname);
			
			this._hostname = hostname;
			this._apps = preinstalledApps;
		}
		get hostname(){return this._hostname;}
		set hostname(hostname){
			this._hostname = hostname;
		}
		get apps(){return this._apps;}
		set apps(apps){
			[].forEach(

			)
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
			return new Device(hostname,apps);
		}
	};
}

// Submit the code above this line in bgcoder.com
module.exports = solve;