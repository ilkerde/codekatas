class Game
  constructor: (@scores=[0,0]) ->

  isOver: ->
    @scores[0] > 1

  scorePlayer: (player) ->
    @scores[--player]++

  currentScore: (f) ->
    display = '0:0'
    display = '15:0' if @scores[0] == 1
    display = '0:15' if @scores[1] == 1
    display

exports.Game = Game

