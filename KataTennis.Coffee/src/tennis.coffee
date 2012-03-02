class Game
  constructor: (@score=0) ->

  isOver: ->
    @score > 1

  scorePlayer: (player) ->
    @score++

  currentScore: () ->
    ''

exports.Game = Game

