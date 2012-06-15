require "calculator"

describe "no numbers given" do
  describe "when given string is emtpy" do
    it "should return 0" do
      (Calculator.add "").should == 0
    end
  end
end

describe "single number" do
  describe "when string contains 5 as number" do
    it "should return 5" do
      (Calculator.add "5").should == 5
    end
  end
end

