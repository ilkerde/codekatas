require 'replacer'

describe "replacer" do
  describe "when template is empty" do
    it "should return empty text" do
      replacer("").should == ""
    end
  end

  describe "when template has literal text only" do
    it "should return text" do
      replacer("text").should == "text"
    end
  end
end
