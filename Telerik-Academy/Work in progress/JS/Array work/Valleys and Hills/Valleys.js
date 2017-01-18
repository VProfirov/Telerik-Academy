function solve(args){
'use strict';
let numbers = args[0].split(' ').map(Number);
let best = -1, current = 0;

    numbers.forEach((number,index,all) =>{
        current += number;//agregation
        // def: start is the end
        if(index === 0) {return ;}
        //def: reached end
        else if(index === all.length - 1){
            best = Math.max(best,current);
            return;
        }
        //def: dependancy :neighbours
        let prev = all[index-1],
            next = all[index+1];
        //def: main condition :reached condition for re-eval
        if(number>prev && number>next){//peak reached
            best = Math.max(best,current);
            current = number; // reset of agregation
        }
    });

    console.log(best);

}

solve([
    "5 1 7 4 8"
]);

function checker(args){
    for(let a of args){
        console.log(a);
    }
}
// Solutions :
//https://github.com/TelerikAcademy/JavaScript-Fundamentals/blob/master/Exams/2015-06-11-Variant-2/1.%20Hills/solution.js

//NB: 
// abstract
    // defragment the logic
        // end conditions
            // mark dependancies 
        // main conditions
    // look for the reseters in each condition

/// relax and keep asking Structured(main logic ? main condition ? edge conditions ? dependencies ? what is needed in each ?) Question