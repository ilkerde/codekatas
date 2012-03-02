(function() {
  var Game;

  Game = (function() {

    function Game(score) {
      this.score = score != null ? score : 0;
    }

    Game.prototype.isOver = function() {
      return this.score > 1;
    };

    Game.prototype.scorePlayer = function(player) {
      return this.score++;
    };

    Game.prototype.currentScore = function() {
      if (this.score === 1) {
        return '15:0';
      } else {
        return '0:0';
      }
    };

    return Game;

  })();

  exports.Game = Game;

}).call(this);
