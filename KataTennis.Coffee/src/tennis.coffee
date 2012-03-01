class Game
  isOver: -> false

  scorePlayer: (player) ->
    @isOver = -> true
    true

exports.Game = Game

