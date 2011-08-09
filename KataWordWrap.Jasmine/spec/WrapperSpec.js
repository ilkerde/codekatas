describe("wrap", function(){
  describe("a long word being longer than marker", function(){
    it("should wrap at marker", function(){
      expect(wrap("wordwrap", 4)).toEqual("word\nwrap");
    });
  });
});
