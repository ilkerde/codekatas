require 'to_roman'

describe "to_roman" do
  describe "when number is 1" do
    it "should return I" do
      1.to_roman.should == "I"
    end
  end

  describe "when number is 2" do
    it "should return II" do
      2.to_roman.should == "II"
    end
  end

  describe "when number is 4" do
    it "should return IV" do
      4.to_roman.should == "IV"
    end
  end

  describe "when number is 5" do
    it "should return V" do
      5.to_roman.should == "V"
    end
  end

  describe "when number is 9" do
    it "should return IX" do
      9.to_roman.should == "IX"
    end
  end

  describe "when number is 10" do
    it "should return X" do
      10.to_roman.should == "X"
    end
  end

  describe "when number is 50" do
    it "should return L" do
      50.to_roman.should == "L"
    end
  end
end
