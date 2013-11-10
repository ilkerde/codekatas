namespace Kata
import NUnit.Framework
import Kata.Point

[TestFixture]
class TennisTest:

    [Test]
    def game_start_love_all():
        game = TennisGame()
        assert game.score == (Love, Love)

    [Test]
    def test_player_one_scores_fifteen_love():
        game = (
            TennisGame()
            .scorePlayerOne())

        assert game.score == (Fifteen, Love)

    [Test]
    def test_player_two_scores_love_fifteen():
        game = (
            TennisGame()
            .scorePlayerTwo())

        assert game.score == (Love, Fifteen)

    [Test]
    def if_player_two_scores_after_player_one_then_fifteen_all():
        game = (
            TennisGame()
            .scorePlayerOne()
            .scorePlayerTwo())

        assert game.score == (Fifteen, Fifteen)

[TestFixture]
class Game_is_at_fifteen_all:
    [Test]
    def if_player_one_scores_then_thirty_fifteen():
        game = (TennisGame(Fifteen, Fifteen)
            .scorePlayerOne()
        )

        assert game.score == (Thirty, Fifteen)

    [Test]
    def if_player_two_scores_then_fifteen_thirty():
        game = (TennisGame(Fifteen, Fifteen)
            .scorePlayerTwo()
        )

        assert game.score == (Fifteen, Thirty)
