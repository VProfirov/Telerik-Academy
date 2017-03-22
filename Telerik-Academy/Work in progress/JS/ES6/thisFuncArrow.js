let invoice = {
	number: 1123,
	p: function(){console.log(this);},
	pp:function(){return function(){return console.log(this);};},
	process:()=>console.log(this),
	process2(){return ()=>console.log(this);}
};
// console.log(invoice.process());
// console.log(invoice.process2()());

let inv = {
	number: 1,
	invoice: invoice,
	invoiceP:function(){console.log(this);}
};
// console.log(inv.invoice.p());
// console.log(inv.invoice.process2()());

// console.log(invoice.pp()());
console.log(inv.invoiceP());
console.log('object');