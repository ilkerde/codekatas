Kata = require './probability'

describe "a probability has a fractional value between 0 and 1", ->
  it "should have a value of 1 when initialized with 1", ->
    p = new Kata.Probability 1
    expect(p.value).toEqual 1
    
  it "should have a value of 1 when initialized with a value above 1", ->
    p = new Kata.Probability 1.5
    expect(p.value).toEqual 1

  it "should have a value of 0 when initialized with a value below 0", ->
    p = new Kata.Probability -0.5
    expect(p.value).toEqual 0

describe "inverted probability", ->
  describe "is 1 minus given probability", ->
    it "should be 0.7 for probability 0.3", ->
      p = (new Kata.Probability 0.3).invert()
      expect(p.value).toEqual 0.7
