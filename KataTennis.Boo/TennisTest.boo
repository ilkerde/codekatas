namespace Kata
import NUnit.Framework

[TestFixture]
class TennisTest:

    [Test]
    def game_start_love_all():
        game = TennisGame()

        assert game.score() == (Love, Love)

    [Test]
    def test_player_one_scores_fifteen_all():
        game = TennisGame()
        game.scorePlayerOne()

        assert game.score() == (Fifteen, Love)
