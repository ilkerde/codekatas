Game = (require 'tennis').Game

describe 'when no player has scored yet', ->
  game = new Game
  it 'should not be game over', ->
    expect(game.isOver()).toBeFalsy()

  describe 'when player 1 scores', ->
    game.scorePlayer 1
    it 'should not be game over', ->
      expect(game.isOver()).toBeFalsy()

describe 'when score is 40:0', ->
  game = new Game
  game.scorePlayer 1
  game.scorePlayer 1
  game.scorePlayer 1

  describe 'when player 1 scores again', ->
    game.scorePlayer 1

    it 'should be game over', ->
      expect(game.isOver()).toBeTruthy()

