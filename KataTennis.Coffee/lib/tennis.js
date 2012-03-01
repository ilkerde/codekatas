(function() {
  var Game;

  Game = (function() {

    function Game() {}

    Game.prototype.isOver = function() {
      return false;
    };

    Game.prototype.scorePlayer = function(player) {
      this.isOver = function() {
        return true;
      };
      return true;
    };

    return Game;

  })();

  exports.Game = Game;

}).call(this);
