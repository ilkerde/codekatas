class Score:
  LOVE = 0
  FIFTEEN = 15
  THIRTY = 30
  FORTY = 40
  ADVANTAGE = 50
  GAME = 100

class TennisGame:
  is_over = False
  
  def __init__(self, score_p1=0, score_p2=0):
    self.score = (score_p1, score_p2)

  def score_player(self, player):
    self.score = tuple(self.inc(x) if i+1==player else x for i,x in enumerate(self.score))
    self.is_over = self.score[player-1] == 50

  def inc(self, score):
    next_offset = self._scoretable.index(score) + 1
    score = self._scoretable[next_offset]
    print score
    return score

  _scoretable = [
    Score.LOVE,
    Score.FIFTEEN,
    Score.THIRTY,
    Score.FORTY,
    Score.ADVANTAGE,
    Score.GAME
  ]

