'use strict';

describe('Game', function() {
  describe('given game starts', function() {
    var game;
    beforeEach(function() {
      game = Game.start();
    });
    it('should read love all on scoreboard', function() {
      expect(Game.scoreBoard).toEqual('LOVE ALL');
    });
  });
});
