require "calculator"

def add numbers
  Calculator.add numbers
end

describe "no numbers given" do
  describe "when given string is emtpy" do
    it "should return 0" do
      (add "").should == 0
    end
  end
end

describe "single number" do
  describe "when string contains 5 as number" do
    it "should return 5" do
      (add "5").should == 5
    end
  end
end

describe "sum of 2 numbers" do
  describe "when passing over 3,5" do
    it "should return 8" do
      (add "3,5").should == 8
    end
  end
end

describe "sum of n numbers" do
  describe "when passing over 3,5,2" do
    it "should return 10" do
      (add "3,5,2").should == 10
    end
  end
end

describe "newline delimiter" do
  describe "when passing over 3\n5" do
    it "should return 8" do
      (add "3\n5").should == 8
    end
  end
end

describe "custom delimiter" do
  describe "when passing over //;\n1;2" do
    it "should return 3" do
      (add "//;\n1;2").should == 3
    end
  end
end

