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

    Game.prototype._anyAboveForty = function() {
      return this.scores[0] > 3 || this.scores[1] > 3;
    };

    Game.prototype._twoPointsAhead = function() {
      return Math.abs(this.scores[0] - this.scores[1]) > 1;
    };

    Game.prototype.isOver = function() {
      return this._anyAboveForty() && this._twoPointsAhead();
    };

    Game.prototype.scorePlayer = function(player) {
      return this.scores[--player]++;
    };

    Game.prototype.currentScore = function(f) {
      var advantageDisplay, display, i, s, textscores, _len, _len2, _ref, _ref2;
      textscores = {};
      _ref = this.scores;
      for (i = 0, _len = _ref.length; i < _len; i++) {
        s = _ref[i];
        textscores[i] = this.scoremap[s];
      }
      advantageDisplay = function(score, index) {
        if (s % 2 === 0) {
          return 'ADV';
        } else {
          return textscores[index];
        }
      };
      if (this._anyAboveForty()) {
        _ref2 = this.scores;
        for (i = 0, _len2 = _ref2.length; i < _len2; i++) {
          s = _ref2[i];
          textscores[i] = advantageDisplay(s, i);
        }
      }
      display = "" + textscores[0] + ":" + textscores[1];
      if (this.isOver()) display = "GAME";
      return display;
    };

    exports.Game = Game;

    return Game;

  })();

}).call(this);
