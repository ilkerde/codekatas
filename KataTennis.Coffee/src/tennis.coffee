class Game
  constructor: (@scores=[0,0]) ->
    @scoremap =
      0: '0'
      1: '15'
      2: '30'
      3: '40'
    
  _anyAboveForty: ->
    (@scores[0] > 3 or @scores[1] > 3)

  _twoPointsAhead: ->
    (Math.abs(@scores[0] - @scores[1]) > 1)

  isOver: ->
    @_anyAboveForty() and @_twoPointsAhead()
    

  scorePlayer: (player) ->
    @scores[--player]++

  currentScore: (f) ->
    textscores = {}
    textscores[i] = @scoremap[s] for s,i in @scores

    advantageDisplay = (score, index) ->
      if s%2 is 0 then 'ADV' else textscores[index]

    if @_anyAboveForty() 
      textscores[i] = advantageDisplay s,i for s,i in @scores

    display = "#{textscores[0]}:#{textscores[1]}"
    display = "GAME" if @isOver() 
    display

  exports.Game = Game

