(function() {
  var Game;

  Game = (function() {

    function Game(scores) {
      this.scores = scores != null ? scores : [0, 0];
    }

    Game.prototype.isOver = function() {
      return this.scores[0] > 1;
    };

    Game.prototype.scorePlayer = function(player) {
      return this.scores[--player]++;
    };

    Game.prototype.currentScore = function(f) {
      var display;
      display = '0:0';
      if (this.scores[0] === 1) display = '15:0';
      if (this.scores[1] === 1) display = '0:15';
      return display;
    };

    return Game;

  })();

  exports.Game = Game;

}).call(this);
