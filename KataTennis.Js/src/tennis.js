'use strict';

var Score = {
  'LOVE': 0,
  'FIFTEEN': 1,
  'THIRTY': 2,

  scan: function(scoreBoard) {
    var scoreTexts = scoreBoard.split(' ');
    var forPlayerOne = scoreTexts[0];
    var forPlayerTwo = scoreTexts[1];

    if (forPlayerTwo === 'ALL') forPlayerTwo = forPlayerOne;

    return [
      Score[forPlayerOne],
      Score[forPlayerTwo]
    ];
  },

  combine: function(scoreCard) {
    var scoreText = ['LOVE', 'FIFTEEN'];

    var scores = scoreCard.map(function(point) {
      return scoreText[point];
    });

    var scoreBoard = scores.join(' ');
    if (scoreBoard === 'LOVE LOVE') scoreBoard = 'LOVE ALL';

    return scoreBoard;
  }
};

var Game = {
  start: function() {
    return this;
  },
  at: function(scoreBoard) {
    this.scoreBoard = scoreBoard;
    return this;
  },
  scorePlayerOne: function() {
    if (this.scoreBoard === 'FIFTEEN LOVE') {
      this.scoreBoard = 'THIRTY LOVE';
    } else {
      this.scoreBoard = 'FIFTEEN LOVE';
    }
  },
  scoreBoard: 'LOVE ALL'
};

