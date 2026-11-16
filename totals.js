// Adds two numbers, and adds up a list of numbers. Used for the JavaScript examples in the course.

function add(a, b) {
  return a + b;
}

function total(numbers) {
  return numbers.reduce(add, 0);
}

module.exports = { add, total };
