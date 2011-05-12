describe('replacing an empty template', function(){
  var target;

  beforeEach(function() {
    target = Replacer;
  });

  it('should yield to an empty text', function(){
    expect(target.replace('')).toEqual('');
  });
});

describe('replacing a text without placeholders', function(){
  it('should yield to given text', function(){
    expect(Replacer.replace('text')).toEqual('text');
  });
});
