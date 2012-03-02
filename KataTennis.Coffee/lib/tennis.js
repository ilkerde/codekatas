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
      return '15:0';
    };

    return Game;

  })();

  exports.Game = Game;

}).call(this);
