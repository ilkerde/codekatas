calc = require './calculator'

describe "simple addition", ->
  it "should return 0 for nothing", ->
    expect(calc.add "").toEqual 0
