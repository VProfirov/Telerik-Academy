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
            }
        }
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
        set name(name) { this._name = name; } //scalable validation-switch(ctor-prop)

        get description() { return this._description; }
        set description(description) { this._description = description; }

        get version() { return this._version; }
        set version(version) { this._version = version; }

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
            fu() { release() }
        }
    }
    //40 min Store
    //40 min Device

    //!NO SEARCHING OR CHECKING BEFORE ALL END! ALL END !
    return {
        createApp(name, description, version, rating) {
            return new App(name, description, version, rating);
        }
    }
}
module.exports = solve;