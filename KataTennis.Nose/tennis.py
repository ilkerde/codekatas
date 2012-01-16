class Score:
  LOVE = 0
  FIFTEEN = 1
  THIRTY = 2
  FORTY = 3
  ADVANTAGE = 4
  GAME = 5

  @staticmethod
  def next(score):
    can_score = score < Score.GAME
    if can_score:
      score += 1
    return score

  @staticmethod
  def is_two_ahead(score_a, score_b):
    return abs(score_a - score_b) > 1

  @staticmethod
  def is_over_forty(score):
    return score > Score.FORTY

class TennisGame:
  is_over = False
  
  def __init__(self, score_p1=Score.LOVE, score_p2=Score.LOVE):
    self.score = score_p1, score_p2

  def score_player(self, player):
    scorer = player - 1;
    looser = 1 - scorer;

    self.score = tuple(
      Score.next(x)
      if i == scorer else x 
      for i, x in enumerate(self.score)
    )

    scorer_score = self.score[scorer]
    looser_score = self.score[looser]

    self.is_over = (
      Score.is_over_forty(scorer_score) and 
      Score.is_two_ahead(scorer_score, looser_score)
    )
