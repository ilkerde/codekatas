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

describe "combined probability", ->
  describe "is the product of two probabilities", ->
    it "should be 0.25 for probabilities 0.5 and 0.5", ->
      p = p_of(0.5).combine p_of(0.5)
      expect(p.value).toEqual 0.25

    it "should be 0.05 for probabilities 0.5 and 0.1", ->
      p = p_of(0.5).combine p_of(0.1)
      expect(p.value).toEqual 0.05

describe "either probability", ->
  describe "is sum of both minus combination of both probabilities", ->
    it "should be 0.75 for probabilities 0.5 and 0.5", ->
      p = p_of(0.5).either p_of(0.5)
      expect(p.value).toEqual 0.75

    it "should be 0.55 for probabilities 0.5 and 0.1", ->
      p = p_of(0.5).either p_of(0.1)
      expect(p.value).toEqual 0.55
