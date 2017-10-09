function solve(args) {
    let chicken = 7;
    let human = 5;
    let bear = 2;
    let legs = Number(args[0]);
    let counter = 0;

    let mostHumanLegs, mostBearLegs;
    let mostChickLegs = Math.floor(legs / chicken);
    for (mostChickLegs; mostChickLegs >= 0; mostChickLegs--) {
        mostHumanLegs = legs - mostChickLegs * chicken;
        mostHumanLegs = Math.floor(mostHumanLegs / human);
        for (mostHumanLegs; mostHumanLegs >= 0; mostHumanLegs--) {
            mostBearLegs = legs - (mostChickLegs * chicken + mostHumanLegs * human)
            mostBearLegs = Math.floor(mostBearLegs / bear);
            if ((mostChickLegs * chicken + mostHumanLegs * human + mostBearLegs * bear) == legs) {
                counter++;
            }
        }
    }
    console.log(counter);
}
solve(["17"]);