describe('replacing an empty template', function(){
  it('should yield to an empty text', function(){
    expect(Replacer.replace('')).toEqual('');
  });
});

describe('replacing a text without placeholders', function(){
  it('should yield to given text', function(){
    expect(Replacer.replace('text')).toEqual('text');
  });
});

describe('replacing template with known placeholder', function(){
  it('should yield to value assigned it placeholder', function(){
    Replacer.placeholders = {
      key: "value"
    };
    expect(Replacer.replace('$key$')).toEqual('value');
  });
});

describe('replacing template with multiple instances of a known placeholder', function(){
  it('should replace all placeholder instances with assigned value', function(){
    Replacer.placeholders = {
      key: "value"
    };
    expect(Replacer.replace('$key$ - $key$')).toEqual('value - value');
  });
});

describe('replacing template with unknown placeholder', function(){
  it('should yield to an empty string replace for a placeholder', function(){
    expect(Replacer.replace('$unknownkey$')).toEqual('');
  });
});
