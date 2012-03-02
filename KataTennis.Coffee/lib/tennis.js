(function() {
  var Game;

  Game = (function() {

    function Game(scores) {
      this.scores = scores != null ? scores : [0, 0];
      this.scoremap = {
        0: '0',
        1: '15',
        2: '30',
        3: '40'
      };
    }

    Game.prototype.isOver = function() {
      return this.scores[0] > 3;
    };

    Game.prototype.scorePlayer = function(player) {
      return this.scores[--player]++;
    };

    Game.prototype.currentScore = function(f) {
      var display;
      display = "" + this.scoremap[this.scores[0]] + ":" + this.scoremap[this.scores[1]];
      return display;
    };

    return Game;

  })();

  exports.Game = Game;

}).call(this);
