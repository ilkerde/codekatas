module FizzBuzz (fizzbuzz)
where
  fizzbuzz n | n `mod` 15 == 0 = "FIZZBUZZ"
             | n `mod` 5 == 0 = "BUZZ"
             | n `mod` 3 == 0 = "FIZZ"
             | otherwise = show n
