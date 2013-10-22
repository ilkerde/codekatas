module FizzBuzz (fizzbuzz)
where
  fizzbuzz n = if (n `mod` 5 == 0) then "BUZZ" else "FIZZ"
