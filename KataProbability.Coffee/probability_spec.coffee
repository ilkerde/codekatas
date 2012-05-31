Kata = require './probability'

p_of = (v) -> new Kata.Probability v

describe "a probability has a fractional value between 0 and 1", ->
  it "should have a value of 1 when initialized with 1", ->
    expect(p_of(1).value).toEqual 1
    
  it "should have a value of 1 when initialized with a value above 1", ->
    expect(p_of(1.5).value).toEqual 1

  it "should have a value of 0 when initialized with a value below 0", ->
    expect(p_of(-0.5).value).toEqual 0

describe "inverted probability", ->
  describe "is 1 minus given probability", ->
    it "should be 0.7 for probability 0.3", ->
      p = p_of(0.3).invert()
      expect(p.value).toEqual 0.7

    it "should be 0.4 for probability 0.6", ->
      p = p_of(0.6).invert()
      expect(p.value).toEqual 0.4
