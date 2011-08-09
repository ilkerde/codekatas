describe("wrap", function(){
  describe("a long word being longer than marker", function(){
    it("should wrap at marker", function(){
      expect(wrap("wordwrap", 4)).toEqual("word\nwrap");
    });
  });

  describe("a short word being shorter than marker", function(){
    it("should not wrap at all", function(){
      expect(wrap("word", 8)).toEqual("word");
    });
  });

  describe("two words with marker being on 2nd word", function(){
    it("should wrap at space between words", function(){
      expect(wrap("any thing", 7)).toEqual("any\nthing");
    });
  });
});
