class Score:
  LOVE = 0
  FIFTEEN = 15
  THIRTY = 30
  FORTY = 40
  ADVANTAGE = 50
  GAME = 100

  _table = [LOVE, FIFTEEN, THIRTY, FORTY, ADVANTAGE, GAME]

  @staticmethod
  def next(score):
    if score == Score.GAME:
      return score

    return Score._table[Score._table.index(score) + 1]

  @staticmethod
  def is_two_ahead(score_a, score_b):
    offset_a = Score._table.index(score_a)
    offset_b = Score._table.index(score_b)
    return abs(offset_a - offset_b) > 1

class TennisGame:
  is_over = False
  
  def __init__(self, score_p1=0, score_p2=0):
    self.score = score_p1, score_p2

  def score_player(self, player):
    scorer = player - 1;
    looser = 1 - scorer;

    self.score = tuple(
      Score.next(x)
      if i == scorer else x 
      for i, x in enumerate(self.score)
    )

    self.is_over = Score.is_two_ahead(self.score[scorer], self.score[looser])
