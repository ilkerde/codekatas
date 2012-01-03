class TennisGame:
  is_over = False
  
  def __init__(self, score_p1=0, score_p2=0):
    self.score = (score_p1, score_p2)

  def score_player(self, player):
    self.is_over = self.score[player-1] == 40
