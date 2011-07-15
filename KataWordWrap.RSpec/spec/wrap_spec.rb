require 'wrap'

describe "word-wrapping long text into lines" do
  describe "no wrapping required" do
    describe "when text is smaller than wrap-column" do
      it "should return text" do
        "text".wrap(7).should == "text"
      end
    end
  end

  describe "break long word apart" do
    describe "when a single word is longer than wrap-column" do
      it "should wrap word into two lines" do
        "text".wrap(2).should == "te\nxt"
      end
    end
  end

  describe "break text with word at spacing" do
    describe "when wrap-column points to 2nd word" do
      it "should wrap text at spacing before 2nd word" do
        "very cool".wrap(7).should == "very\ncool"
      end
    end

    describe "when wrap-column points to end of 1st word" do
      it "should wrap text at spacing after 1st word" do
        "very cool".wrap(4).should == "very\ncool"
      end
    end

    describe "when wrap-column points at mutliple lines to 2nd word" do
      it "should wrap text at spacing before 2nd word" do
        "very cool thing".wrap(7).should == "very\ncool\nthing"
      end
    end
  end
end
