game = (require 'tennis').game
score = (require 'tennis').score

describe 'when no player has scored yet', ->
  it 'should not be game over', ->
    expect(game.isOver()).toBeFalsy()

describe 'when score is 40:0', ->
  game.scorePlayer 1
  game.scorePlayer 1
  game.scorePlayer 1

  describe 'when player 1 scores again', ->
    game.scorePlayer 1

    it 'should be game over', ->
      expect(game.isOver()).toBeTruthy()

