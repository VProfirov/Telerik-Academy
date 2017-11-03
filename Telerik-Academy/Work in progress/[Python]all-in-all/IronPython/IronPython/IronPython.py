class AnonType(dict):
    __getattr__ = dict.get
    __setattr__ = dict.__setitem__

dog = AnonType(
    age=7,
    name="Rover"
)
if dog.age > 5:
    # treat dog as older
    print(dog)

