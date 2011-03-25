require 'fizzbuzz'

describe "fizzbuzz, translate" do
	it "returns fizz for multiples of three" do
		FizzBuzz.new.translate(3).should == "fizz"
	end
end

