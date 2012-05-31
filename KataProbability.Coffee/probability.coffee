root = exports ? this

class Probability
  constructor: (@value) ->
    @value = 1 if @value > 1
    @value = 0 if @value < 0

root.Probability = Probability
