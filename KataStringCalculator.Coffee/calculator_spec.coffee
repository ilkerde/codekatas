calc = require './calculator'

describe "simple addition", ->
  it "should return 0 for nothing", ->
    expect(calc.add "").toEqual 0

  it "should return number for single number", ->
    expect(calc.add "3").toEqual 3

  it "should return sum of two comma-separated numbers", ->
    expect(calc.add "2,3").toEqual 5

describe "summation of multiple numbers", ->
  it "should return sum of arbitrary numbers separated by comma", ->
    expect(calc.add "1,2,3,5").toEqual 11

describe "alternative separators", ->
  it "should accept newline as alternative number separator", ->
    expect(calc.add """
    1
    2
    3
    """).toEqual 6

  it "should accept a custom separator in a prefix string sequence", ->
    expect(calc.add """//:
    1:2:3""").toEqual 6

describe "negative numbers handling", ->
  it "should throw exception when negative numbers are passed", ->
    expect(() -> calc.add "1,-2,3,-5").toThrow(new RangeError)
