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

	it "returns number for no multiples of five or three" do
		FizzBuzz.new.translate(1).should == "1"
	end
end

describe "fizzbuzz, translate_all" do
	it "returns list of 100 entries for start number 1 and stop number 100" do
		FizzBuzz.new.translate_all(1, 100).length.should == 100
	end

	it "uses translation for a range number" do
		FizzBuzz.should_receive(:translate).and_return("buzz")

		FizzBuzz.new.translate_all(5, 5).each do |translation|
			translation.should == "buzz"
		end
	end
end

