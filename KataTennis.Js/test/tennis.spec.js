'use strict';

describe('Game', function() {
  var game;
  describe('given game starts', function() {
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

  describe('given game is FIFTEEN LOVE', function() {
    beforeEach(function() {
      game = Game.at('FIFTEEN LOVE');
    });

    describe('when player one scores', function() {
      beforeEach(function() {
        game.scorePlayerOne();
      });

      it('should read THIRTY LOVE on scoreboard', function() {
        expect(game.scoreBoard).toBe('THIRTY LOVE');
      });
    });
  });
});

describe('Score scan', function() {
  var score, scoreCard;

  describe('given score is FIFTEEN LOVE', function(){
    beforeEach(function(){
      scoreCard = Score.scan('FIFTEEN LOVE');
    });

    it('should have 1 for player 1 on score card', function() {
      var playerOneScore = scoreCard[0];
      expect(playerOneScore).toBe(1);
    });

    it('should have 0 for player 2 on score card', function() {
      var playerTwoScore = scoreCard[1];
      expect(playerTwoScore).toBe(0);
    });
  });

  describe('given score is LOVE ALL', function(){
    beforeEach(function(){
      scoreCard = Score.scan('LOVE ALL');
    });

    it('should have 0 for player one on score card', function() {
      var playerOneScore = scoreCard[0];
      expect(playerOneScore).toBe(0);
    });

    it('should have 0 for player two on score card', function() {
      var playerTwoScore = scoreCard[1];
      expect(playerTwoScore).toBe(0);
    });
  });
});

describe('Score combine', function() {
  var score, scoreBoard;

  describe('given score card reads [1,0]', function() {
    beforeEach(function(){
      scoreBoard = Score.combine([1,0]);
    });

    it('should read FIFTEEN LOVE on score board', function() {
      expect(scoreBoard).toBe('FIFTEEN LOVE');
    });
  });

  describe('given score card reads [0,0]', function() {
    beforeEach(function(){
      scoreBoard = Score.combine([0,0]);
    });

    it('should read LOVE ALL on score board', function() {
      expect(scoreBoard).toBe('LOVE ALL');
    });
  });
});
