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
