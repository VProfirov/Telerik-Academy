function solve() {
    const VALIDATOR = {
        //TODO: Run GRUNT to task-manage the lintification and fixing of the missing (;)
        validateName(name) {
            // FIXME: pattern with multiple spaces (/^[a-zA-Z0-9\s]*{1,24}$/)
            if (typeof name != 'string' || name.match(/^[a-zA-Z0-9]*\s{1,24}$/)) {
                throw Error(`Invalid string (${name}) to be assigned as name`)
            }
        },
        validateDescription(description) {
            //FIXME: if string is empty or conists of one or more spaces - only
            if (typeof description != 'string') {
                throw Error(`Invalid (${description}) not a string`)
            }
        },
        validateVersion(version) {
            if (typeof version != 'number' || !(version > 0) || Number.isNaN) {
                throw Error(`Invalid (${version}) not a valid positive number`)
            }
        },
        validateRating(rating) {
            if (typeof rating != 'number' || rating > 10 || rating < 1) {
                throw Error(`Invalid (${rating}) not a number in the range of 1 to 10 included`)
            }
        },

        validateApp(app) {
            if (!(app instanceof App)) {
                throw Error(`${app} is not and instance of the App class`);
            }
        },

        validateHostname(hostname) {
            if (typeof hostname !== 'string' || hostname.length > 32 || hostname.length < 1) {
                throw Error(`${hostname} is not valid string with length between 1-32`);
            }
        }
    };
    // NON SCALABLE DEV-PATTERN// ctor-valdiation;
    //30 min App
    class App {
        constructor(name, description, version, rating) {
            VALIDATOR.validateName(name);
            VALIDATOR.validateDescription(description);
            VALIDATOR.validateVersion(version);
            VALIDATOR.validateRating(rating);

            this.name = name;
            this.description = description;
            this.version = version;
            this.rating = rating;
        }

        get name() { return this._name; }
        // set name(name) { this._name = name; } //scalable validation-switch(ctor-prop) !NB! no settters

        get description() { return this._description; }
        // set description(description) { this._description = description; }

        get version() { return this._version; }
        // set version(version) { this._version = version; }

        get rating() { return this._rating; }
        set rating(rating) { this._rating = rating; }


        release(options) {
            // value to object re-treatment
            if (typeof options != 'object') {
                options = { version: options };
            }

            VALIDATOR.validateVersion(options.version);
            if (options.version <= version) {
                throw Error(`Invalid (${options.version}) is not above the old one`)
            }
            this.version = options.version;

            if (options.hasOwnProperty('description')) {
                VALIDATOR.validateDescription(options.description);
                this.description = options.description;
            }

            if (options.hasOwnProperty('rating')) {
                VALIDATOR.validateRating(options.rating);
                this.version = options.version;
            }
            return this;
        }
    }

    //40 min Store
    class Store extends App {
        constructor(...params) {
            super(...params);
            this.apps = [];
        }

        get apps() { return this._apps; }

        uploadApp(app) {
            //instancecheck
            // same name app: 
            // NOT : *upload the app -/- create new app
            // *update the app 
            // newer version
            //check if verion is bigger then the last one => chainable .version
            // description
            // rating
            /**chaing */
        }

        takedownApp(name) {
            //finds the._app[i].name === name
            //if not found : throws Error (not found)
            /**chaining */
        }

        search(pattern) {
            //case-insensitive .find
            //**returns apps[].name.match(/*name -/- app.name*/)
            // sort apps lexicographically by name ??
        }

        listMostRecentApps(count) {}

        listMostPopularApps(count) {}
    }
    //40 min Device
    class Device {
        constructor() {} //Constructor or init method
            /**takes `hostname` and an **array of pre-installed apps** (e.g. default store) */
            // throws :if `hostname` is not valid
            //FIXME: ->->
            // throws : if there is an invalid app

        get hostname() {}
        // set hostname() {}

        get apps() {}
        // set apps() {}

        search(pattern) {}
        install(name) {} /**chaining */ //throw :if app `name` is not available in installed stores
        uninstall(name) {} /**chaining */ //throw :if no such app is installed
        listInstalled() {}
        update() {} /**chaining */
    }
    //!NO SEARCHING OR CHECKING BEFORE ALL END! ALL END !
    return {
        createApp(name, description, version, rating) {
            return new App(name, description, version, rating);
        }

    };
}
module.exports = solve;