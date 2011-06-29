require 'wrap'

describe "word-wrapping long text into lines" do
  describe "no wrapping required" do
    describe "when text is smaller than wrap-column" do
      it "should return text" do
        "text".wrap(7).should == "text"
      end
    end
  end
end
