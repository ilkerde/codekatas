class Game
  constructor: (@score=0) ->

  isOver: ->
    @score > 1

  scorePlayer: (player) ->
    @score++

  currentScore: () ->
    if @score == 1 then '15:0' else '0:0'

exports.Game = Game

