import Test.Hspec
import Test.QuickCheck
import FizzBuzz

main :: IO ()
main = hspec $ do
  describe "multiples of 3" $ do
    it "returns FIZZ" $ do
      fizzbuzz 6 `shouldBe` "FIZZ"

