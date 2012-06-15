require "calculator"

describe "no numbers given" do
  describe "when given string is emtpy" do
    it "should return 0" do
      (Calculator.add "").should == 0
    end
  end
end

