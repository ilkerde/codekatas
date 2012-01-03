class Score:
  LOVE = 0
  FIFTEEN = 15
  THIRTY = 30
  FORTY = 40
  GAME = 100

  _table = [LOVE, FIFTEEN, THIRTY, FORTY, GAME]

  @staticmethod
  def next(score):
    if score == Score.GAME:
      return score

    return Score._table[Score._table.index(score) + 1]

class TennisGame:
  is_over = False
  
  def __init__(self, score_p1=0, score_p2=0):
    self.score = score_p1, score_p2

  def score_player(self, player):
    self.score = tuple(
      Score.next(x)
      if i + 1 == player else x 
      for i, x in enumerate(self.score)
    )
    self.is_over = self.score[player-1] == Score.GAME
