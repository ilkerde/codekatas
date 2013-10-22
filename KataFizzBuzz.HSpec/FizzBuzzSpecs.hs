import Test.Hspec
import Test.QuickCheck
import FizzBuzz

main :: IO ()
main = hspec $ do
  describe "multiples of 3" $ do
    it "returns FIZZ" $ do
      fizzbuzz 6 `shouldBe` "FIZZ"

  describe "multiples of 5" $ do
    it "returns BUZZ" $ do
      fizzbuzz 10 `shouldBe` "BUZZ"

  describe "multiples of 3 and 5" $ do
    it "returns FIZZBUZZ" $ do
      fizzbuzz 30 `shouldBe` "FIZZBUZZ"
