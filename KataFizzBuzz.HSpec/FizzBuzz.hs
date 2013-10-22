module FizzBuzz (fizzbuzz)
where
  fizzbuzz n | n `mod` 5 == 0 = "BUZZ"
             | otherwise = "FIZZ"
