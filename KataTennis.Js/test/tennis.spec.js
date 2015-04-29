'use strict';

describe('Game', function() {
  describe('given game starts', function() {
    var game;

    beforeEach(function() {
      game = Game.start();
    });

    it('should read LOVE ALL on scoreboard', function() {
      expect(game.scoreBoard).toEqual('LOVE ALL');
    });

    describe('when player one scores', function() {
      beforeEach(function() {
        game.scorePlayerOne();
      });

      it('should read FIFTEEN LOVE on scoreboard', function() {
        expect(game.scoreBoard).toBe('FIFTEEN LOVE');
      });
    });
  });
});
