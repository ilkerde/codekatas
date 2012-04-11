loc = require './loc'

sample = {
  multilinecode: """line 1
  line 2
  line 3"""
}

describe "standard code lines", ->
  it "should count a line with simple text", ->
    expect(loc.count "test").toEqual 1

  it "should count multiple lines with simple text", ->
    expect(loc.count sample.multilinecode).toEqual 3
