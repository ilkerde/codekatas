describe('replacing an empty template', function(){
  var target;

  beforeEach(function() {
    target = Replacer;
  });

  it('should yield to an empty text', function(){
    expect(target.replace('')).toEqual('');
  });
});
