require 'to_roman'

describe "to_roman" do
  describe "when number is 1" do
    it "should return I" do
      1.to_roman.should == "I"
    end
  end

  describe "when number is 5" do
    it "should return V" do
      5.to_roman.should == "V"
    end
  end
end
