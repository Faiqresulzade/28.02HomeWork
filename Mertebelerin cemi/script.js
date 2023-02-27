let number = 1234;
let sum = 0;
let qaliq = number % 10;
while (number > 0) {
  sum = sum + (((number - (number % 10)) / 10) % 10); //((1234-(4))/10)%10
  //console.log(sum)
  number = number / 10;
}
console.log(sum + qaliq);
