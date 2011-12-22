from tennis import TennisGame

tennis = TennisGame()

def when_score_is_love_all_then_game_is_not_over_test():
  assert tennis.is_over == False
