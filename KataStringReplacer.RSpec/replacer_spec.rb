require 'replacer'

describe "replacer" do
  describe "when template is empty" do
    it "should return empty text" do
      replacer("").should == ""
    end
  end
end
