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

  describe "when template has known placeholder" do
    it "should return value of placeholder" do
      placeholders = { "key" => "value" }
      replacer("$key$", placeholders).should == "value"
    end
  end

  describe "when template has unknown placeholder" do
    it "should return the literal text only" do
      replacer("$what$").should == ""
    end
  end
end
