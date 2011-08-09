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
});
