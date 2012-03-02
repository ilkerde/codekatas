class Game
  constructor: (@scores=[0,0]) ->
    @scoremap =
      0: '0'
      1: '15'
      2: '30'
      3: '40'
    
  isOver: ->
    @scores[0] > 3

  scorePlayer: (player) ->
    @scores[--player]++

  currentScore: (f) ->
    display = "#{@scoremap[@scores[0]]}:#{@scoremap[@scores[1]]}"
    display

exports.Game = Game

