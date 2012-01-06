from tennis import TennisGame
from tennis import Score

def when_score_is_love_all_then_game_is_not_over_test():
  tennis = TennisGame()
  assert tennis.is_over == False

def when_score_is_forty_love_and_p1_score_then_game_is_over_test():
  tennis = TennisGame(Score.FORTY, Score.LOVE)
  tennis.score_player(1)
  assert tennis.is_over == True

def when_score_is_love_all_and_p1_score_then_game_is_not_over_test():
  tennis = TennisGame()
  tennis.score_player(1)
  assert not tennis.is_over

def when_score_is_love_forty_and_p2_score_then_game_is_over_test():
  tennis = TennisGame(Score.LOVE, Score.FORTY)
  tennis.score_player(2)
  assert tennis.is_over == True

def when_score_is_love_all_and_p1_score_then_score_is_fifteen_love_test():
  tennis = TennisGame()
  tennis.score_player(1)
  assert tennis.score == (Score.FIFTEEN, Score.LOVE)

def when_score_is_forty_all_and_p1_score_then_game_is_not_over_test():
  tennis = TennisGame(Score.FORTY, Score.FORTY)
  tennis.score_player(1)
  assert not tennis.is_over
