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
    var scoreText = ['LOVE', 'FIFTEEN', 'THIRTY'];

    var scores = scoreCard.map(function(point) {
      return scoreText[point];
    });

    var scoreBoard = scores.join(' ');
    if (scoreBoard === 'LOVE LOVE') scoreBoard = 'LOVE ALL';

    return scoreBoard;
  }
};

var Game = function() {
  return {
    start: function() {
      return this;
    },

    at: function(scoreBoard) {
      this.scoreBoard = scoreBoard;
      return this;
    },

    scorePlayerOne: function() {
      var scoreCard = Score.scan(this.scoreBoard);
      scoreCard[0]++;
      this.scoreBoard = Score.combine(scoreCard);
    },

    scorePlayerTwo: function() {
      var scoreCard = Score.scan(this.scoreBoard);
      scoreCard[1]++;
      this.scoreBoard = Score.combine(scoreCard);
    },

    scoreBoard: 'LOVE ALL'
  };
}

