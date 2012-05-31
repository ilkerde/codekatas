root = exports ? this

class Probability
  constructor: (@value) ->
    @value = 1 if @value > 1

root.Probability = Probability
