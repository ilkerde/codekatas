root = exports ? this

class Probability
  constructor: (@value) ->
    @value = 1 if @value > 1
    @value = 0 if @value < 0

  invert: ->
    new Probability 1-@value

  combine: (p) ->
    new Probability (@value * p.value)

  either: (p) ->
    sum = @value + p.value
    combined = (@combine p).value

    new Probability (sum - combined)

root.Probability = Probability
