class TennisGame:
  is_over = False
  
  def __init__(self, score_p1=0, score_p2=0):
    self.score = (score_p1, score_p2)

  def score_player_1(self):
    self.is_over = self.score[0] == 40

  def score_player_2(self):
    pass
