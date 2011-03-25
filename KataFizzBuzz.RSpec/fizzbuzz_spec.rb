require 'fizzbuzz'

describe "fizzbuzz, translate" do
	it "returns fizz for multiples of three" do
		FizzBuzz.new.translate(3).should == "fizz"
	end

	it "returns buzz for multiples of five" do
		FizzBuzz.new.translate(5).should == "buzz"
	end

	it "returns fizzbuzz for multiples of five and three" do
		FizzBuzz.new.translate(15).should == "fizzbuzz"
	end
end

