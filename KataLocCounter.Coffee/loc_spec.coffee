loc = require './loc'

describe "standard code lines", ->
  it "should count a line with simple text", ->
    expect(loc.count "test").toEqual 1

  it "should count multiple lines with simple text", ->
    expect(loc.count """line 1
    line 2
    line 3""").toEqual 3

  it "should not count empty lines", ->
    expect(loc.count """
      l1

      l2
    """).toEqual 2

