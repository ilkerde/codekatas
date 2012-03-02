class Game
  constructor: (@scores=[0,0]) ->
    @scoremap =
      0: '0'
      1: '15'
      2: '30'
      3: '40'
    
  isOver: ->
    (@scores[0] > 3 or @scores[1] > 3) and
    (Math.abs(@scores[0] - @scores[1]) > 1)

  scorePlayer: (player) ->
    @scores[--player]++

  currentScore: (f) ->
    textscores = {}
    textscores[i] = @scoremap[s] for s,i in @scores

    if (@scores[0] > 3 or @scores[1] > 3)
      textscores[i] = (if s%2 is 0 then 'ADV' else textscores[i]) for s,i in @scores
    else

    display = "#{textscores[0]}:#{textscores[1]}"
    display

exports.Game = Game

