game = (require 'tennis').game

describe 'when no player has scored yet', ->
  it 'should not be game over', ->
    expect(game.isOver()).toBeFalsy()
