loc = require './loc'

describe "standard code lines", ->
  it "should count a line with simple text", ->
    expect(loc.count "test").toEqual 1

