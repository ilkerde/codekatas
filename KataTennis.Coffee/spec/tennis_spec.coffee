Game = (require 'tennis').Game

describe 'when no player has scored yet', ->
  game = 

  beforeEach () -> 
    game = new Game

  it 'should not be game over', ->
    expect(game.isOver()).toBeFalsy()

  it 'should have score 0:0', ->
    expect(game.currentScore()).toEqual '0:0'

  describe 'when player 1 scores', ->
    game = 

    beforeEach () ->
      game = new Game
      game.scorePlayer 1

    it 'should not be game over', ->
      expect(game.isOver()).toBeFalsy()

    it 'should 15:0', ->
      expect(game.currentScore()).toEqual '15:0'

  describe 'when player 2 scores', ->
    game = 

    beforeEach () ->
      game = new Game
      game.scorePlayer 2

    it 'should not be game over', ->
      expect(game.isOver()).toBeFalsy()

    it 'should 0:15', ->
      expect(game.currentScore()).toEqual '0:15'

describe 'when score is 15:0', ->
  game = 

  beforeEach () ->
    game = new Game [1,0]

  describe 'when player 1 scores', ->
    game =

    beforeEach () ->
      game.scorePlayer 1

    it 'should not be game over', ->
      expect(game.isOver()).toBeFalsy()

describe 'when score is 40:0', ->
  game =

  beforeEach () ->
    game = new Game [3,0]

  describe 'when player 1 scores again', ->
    game =

    beforeEach () ->
      game.scorePlayer 1

    it 'should be game over', ->
      expect(game.isOver()).toBeTruthy()

