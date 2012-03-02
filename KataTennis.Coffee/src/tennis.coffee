class Game
  constructor: (@score=0) ->

  isOver: ->
    @score > 1

  scorePlayer: (player) ->
    @score++

  currentScore: () ->
    '15:0'

exports.Game = Game

