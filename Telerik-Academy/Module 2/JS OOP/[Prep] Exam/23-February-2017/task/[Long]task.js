function solve() {
    const VALIDATOR = {
        //STRINGS
        validateString(target) {
            if (typeof target !== 'string') {
                throw Error('Not a string');
            }
        },
        validateStringLength(target) {
            if (target.length > 24 || target.length < 1) {
                throw Error(`${target}\'s length is out side of the 1-24 char boundery`);
            }
        },
        validateStringPattern(target) {
            if (!target.match(/^([a-zA-Z0-9]|\s){1,24}$/))
                throw Error(`"${target}" can be a string with length between 1 and 24 latin letters, numbers and whitespace `);
        },
        //NUMBERS
        validatePositiveNumber(target) {
            if (typeof target != "number" && target < 0 || Number.isNaN(target)) {
                throw Error(`${target} is not a positive number`)
            }
        },
        validateNumberInRange(target) {
            if (typeof target != "number" || target > 10 || target < 1 || Number.isNaN(target)) {
                //isNaN for a inside-range (1-10) is useless, but for outside check is useful
                throw Error(`${target} is not valid number in range 1-10`);
            }
        }
        //TODO: Add the rest of the validation for FIXME: the APP class

    };

    class App {
        constructor(name, description, version, rating) {
            this.name = name;
            this.description = description;
            this.version = version;
            this.rating = rating;
            // case ?: value || default.init
        }
        get name() { return this._name; }
        set name(name) {
            VALIDATOR.validateString(name);
            VALIDATOR.validateStringLength(name);
            VALIDATOR.validateStringPattern(name);

            this._name = name;
        }

        get description() { return this._description; }
        set description(description) {
            VALIDATOR.validateString(description);

            this._description = description;
        }

        get version() { return this._version; }
        set version(version) {
            VALIDATOR.validatePositiveNumber(version);
            this._version = version;
        }

        get rating() { return this._rating; }
        set rating(rating) { this._rating = rating; }

        release(options) {
            //if (options is value)
            if (options != 'object') {
                options = { version: options }
            }

            // NO use of : operations.hasOwnProperty('version')...
            if (options.version <= version) { throw Error('Invalid new version'); }
            // VALIDATOR.validatePositiveNumber(options.version)
            this.version = options.version;

            if (options.hasOwnProperty('description')) {
                VALIDATOR.validateString(options.description);
                this.description = options.description;
            }

            if (options.hasOwnProperty('rating')) {
                VALIDATOR.validateNumberInRange(options.rating);
                this.rating = options.rating;
            }

        }
    }

    // class Store extends App {
    //     constructor(name, description, version, rating) {
    //         super(name, description, version, rating);
    //         this._apps = [];
    //     }
    //     uploadApp(app) {
    //         if (app instanceof new App) {

    //         }
    //     }
    // }

    // class Device {
    //     constructor(hostname, apps) {
    //         this._hostname = hostname;
    //         this._apps = apps;
    //     }
    // }

    return {
        createApp(name, description, version, rating) {
            return new App(name, description, version, rating);
        },
        createStore(name, description, version, rating) {
            // return new Store(name, description, version, rating);
        },
        createDevice(hostname, apps) {
            // return new Device(hostname, apps);
        }
    };
}
module.exports = solve;