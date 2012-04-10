calc = require './calculator'

describe "simple addition", ->
  it "should return 0 for nothing", ->
    expect(calc.add "").toEqual 0

  it "should return number for single number", ->
    expect(calc.add "3").toEqual 3
