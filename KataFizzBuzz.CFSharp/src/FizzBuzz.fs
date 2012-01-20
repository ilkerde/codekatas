namespace Kata

module FizzBuzz =
  let translate number =
    let fizz = if number % 3 = 0 then "Fizz" else ""
    let buzz = if number % 5 = 0 then "Buzz" else ""

    fizz + buzz
