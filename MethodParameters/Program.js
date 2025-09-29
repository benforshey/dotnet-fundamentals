var a = 3;
var b = 4;
var c = 0;

multiply(a, b, c);
console.log(`global statement: ${a} x ${b} = ${c}`);

function multiply(a, b, c) {
  c = a * b;

  console.log(`inside Multiply method: ${a} x ${b} = ${c}`);
}
